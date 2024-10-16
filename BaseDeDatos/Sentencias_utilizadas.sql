--SELECT * FROM Usuario

--SELECT * FROM Rol

--INSERT INTO Rol(descripcion)
--VALUES('Administrador')

--INSERT INTO Usuario(DNI,Nombre_completo,Email,Pass,telefono,direccion,estado,id_rol)
--VALUES ('40404040','Enzo','admin@gmail.com','123','3794111111','calle123',1,1)

--INSERT INTO Usuario(DNI,Nombre_completo,Email,Pass,telefono,direccion,estado,id_rol)
--VALUES ('20202020','Damian','vende@gmail.com','123','3794222222','calle456',1,2)

--INSERT INTO Usuario(DNI,Nombre_completo,Email,Pass,telefono,direccion,estado,id_rol)
--VALUES ('10101010','Fabian','super@gmail.com','123','3794333333','calle789',1,3)

--INSERT INTO Rol(descripcion)
--VALUES('Vendedor')


--INSERT INTO Rol(descripcion)
--VALUES('Supervisor')


----consulta para llevar todos los usuario a la cd_usuarios--
--select u.id_usuario,u.DNI,u.Nombre_completo,u.Email,u.Pass,u.telefono,u.direccion,u.estado,r.id_rol,r.descripcion from Usuario u
--inner join Rol r on r.id_rol = u.id_rol


--procedimientos almacenados para USUARIOS ALTA BAJA Y MODIFICACION--

--Registrar usuario--

--SELECT * FROM Usuario


/*PRCEDIMIENTOS ALMACENADOS PARA USUARIOS*/

create PROC SP_RegistrarUsuario(
@DNI varchar(50),
@Nombre_completo varchar(100),
@Email varchar(100),
@Pass varchar(100),
@telefono varchar(100),
@direccion varchar(100),
@id_rol int,
@estado bit,
@id_usuarioResultado int output,
@mensaje varchar(100) output
)
as 
begin 
  set @id_usuarioResultado = 0
  set @mensaje = ''

  if not exists(select * from Usuario 
  where DNI = @DNI)
  begin
      insert into Usuario(DNI,Nombre_completo,Email,Pass,telefono,direccion,estado,id_rol) values 
	  (@DNI,@Nombre_completo,@Email,@Pass,@telefono,@direccion,@estado,@id_rol)

	  set @id_usuarioResultado = SCOPE_IDENTITY()

	  end
	  else 
	  set @mensaje = 'No se puede repetir el numero de documento para m�s de un usuario'
  end

 --editar Usuario--

 create PROC SP_EditarUsuario(
@id_usuario int,
@DNI varchar(50),
@Nombre_completo varchar(100),
@Email varchar(100),
@Pass varchar(100),
@telefono varchar(100),
@direccion varchar(100),
@id_rol int,
@estado bit,
@Respuesta int output,
@mensaje varchar(100) output
)
as 
begin 
  set @Respuesta = 0
  set @mensaje = ''

  if not exists(select * from Usuario 
  where DNI = @DNI and id_usuario != @id_usuario)
  begin
      update Usuario set
	  DNI = @DNI,
	  Nombre_completo = @Nombre_completo,
	  Email = @Email,
	  Pass = @Pass,
	  telefono = @telefono,
	  direccion = @direccion,
	  estado = @estado,
	  id_rol = @id_rol
	  where id_usuario = @id_usuario

	 set @Respuesta = 1

	 end 
	 else 
	    set @mensaje = 'No se puede repetir el documento para mas de un usuario'
  end

  --prueba EDITAR--

  --declare @Respuesta bit
  --declare @mensaje varchar(100)

  --exec SP_EditarUsuario 4, '303030','Javier','vende@gmail.com','123',3794444444,'calle789',2,1,@Respuesta output,@mensaje output 

  --select @Respuesta
  --select @mensaje
  --SELECT * FROM Usuario


  ---Eliminar usuario--

create PROC SP_EliminarUsuario(
@id_usuario int,
@Respuesta int output,
@mensaje varchar(100) output
)
as 
BEGIN 
  set @Respuesta = 0
  set @mensaje = ''

  --VALIDAR QUE NO ESTE RELACIONADO A UNA COMPRA O UNA VENTA
  DECLARE @regla bit = 1

  IF EXISTS (SELECT * FROM Compra c
  INNER JOIN Usuario u ON u.id_usuario = c.id_usuario
  WHERE u.id_usuario = @id_usuario
  )
     BEGIN 
	 set @regla = 0
     set @Respuesta = 0
     set @mensaje = @mensaje + 'No se puede eliminar porque el usuario se encuentra relacionado a una compra'
     END

	   IF EXISTS (SELECT * FROM Venta v
       INNER JOIN Usuario u ON u.id_usuario = v.id_usuario
       WHERE u.id_usuario = @id_usuario
       )
       BEGIN
	   set @regla = 0
       set @Respuesta = 0
       set @mensaje = @mensaje + 'No se puede eliminar porque el usuario se encuentra relacionado a una venta'
       END

	       IF (@regla = 1)
		   BEGIN 
		       DELETE FROM Usuario 
			   WHERE id_usuario = @id_usuario
			   set @Respuesta = 1
	       END
 END


 /*PRCEDIMIENTOS ALMACENADOS PARA CATEGORIAS*/

 --REGISTRAR CATEGORIA

 create PROC SP_RegistrarCategoria(
 @Descripcion varchar(100),
 @Estado bit,
 @Resultado int output,
 @mensaje varchar(100) output
 )as
 begin 
      SET @Resultado = 0
	  IF NOT EXISTS (SELECT * FROM categoria WHERE descripcion = @Descripcion)
	  begin 
	       insert into categoria(descripcion,estado) values (@Descripcion,@Estado)
		   set @Resultado = SCOPE_IDENTITY()
	  end
	  ElSE
	     set @mensaje = 'Esta categoria ya existe'
end

--Editar una cateogria

create PROC SP_SP_EditarCategoria(
 @id_categoria int,
 @Descripcion varchar(100),
 @Estado bit,
 @Resultado int output,
 @mensaje varchar(100) output
 )as
 begin 
      SET @Resultado = 1
	  IF NOT EXISTS (SELECT * FROM categoria WHERE descripcion = @Descripcion and id_categoria != @id_categoria)
	  update categoria set 
	      descripcion = @Descripcion,
		  estado = @Estado
		  where id_categoria = @id_categoria
	  ElSE
	     begin
		 set @Resultado = 0
	     set @mensaje = 'Esta categoria ya existe'
		 end
end

--Eliminar CATEGORIA

 create PROC SP_EliminarCategoria(
 @id_categoria int,
 @Descripcion varchar(100),
 @Resultado int output,
 @mensaje varchar(100) output
 )as
 begin 
      SET @Resultado = 1
	  IF NOT EXISTS (
	  SELECT * FROM categoria c
	  inner join producto p on p.id_categoria = c.id_categoria
	  WHERE c.id_categoria = @id_categoria
	  )
	  begin
	      delete top(1) from categoria
		  where id_categoria = @id_categoria
	  end
	  ELSE
	     begin
		 set @Resultado = 0
	     set @mensaje = 'No se puede realizar esta accion porque la categoria esta asignada a un producto'
		 end
end


select * from categoria

/*PRODUCTOS*/

---AGREGAR UN PRODUCTO---

CREATE PROCEDURE sp_alta_producto
    @codigo VARCHAR(100),
    @nombre VARCHAR(100),
    @descripcion VARCHAR(100),
    @id_categoria INT,
	@estado BIT,
	@Resultado int output,
	@mensaje varchar(100) output
AS
BEGIN
    SET @Resultado = 0;

    -- Verificar si el producto ya existe
    IF NOT EXISTS (SELECT 1 FROM producto WHERE codigo = @codigo)
	    -- Inserci�n del nuevo producto
		BEGIN
    INSERT INTO producto (codigo,Nombre,descripcion,estado,id_categoria)
    VALUES (@codigo, @nombre, @descripcion,@estado, @id_categoria);
	SET @Resultado = SCOPE_IDENTITY();
	    END
	ELSE
    SET @mensaje = 'Ya existe un producto con el mismo codigo'
    
END;

---EDITAR UN PRODCUTO---

CREATE PROCEDURE sp_modificar_producto
    @id_producto int,
    @codigo VARCHAR(100),
    @nombre VARCHAR(100),
    @descripcion VARCHAR(100),
    @estado BIT,
    @id_categoria INT,
	@Resultado int output,
	@mensaje varchar(100) output
AS
BEGIN
    SET @Resultado = 1;

    IF NOT EXISTS (SELECT 1 FROM producto WHERE codigo = @codigo and id_producto != @id_producto)
	   UPDATE producto SET
	   codigo = @codigo,
	   Nombre = @nombre,
	   descripcion =@descripcion,
	   id_categoria = @id_categoria
	   WHERE id_producto = @id_producto
	ELSE
	    BEGIN
		SET @Resultado = 0;
		SET @mensaje = 'Ya existe un producto con el mismo codigo';
		END
END;


---ELIMINAR UN PRODCUTO---

CREATE PROCEDURE sp_eliminar_producto
    @id_producto int,
	@Resultado int output,
	@mensaje varchar(100) output
AS
BEGIN
    SET @Resultado = 0;
	SET @mensaje = '';
    DECLARE @validacion bit = 1

	--SI EL PRODUCTO ESTA RELACIONADO A UNA COMPRA--
	IF EXISTS (SELECT * FROM Detalle_Compra dc
	INNER JOIN producto p ON p.id_producto = dc.id_producto
	WHERE p.id_producto = @id_producto)

	  BEGIN
	  SET @validacion = 0
	  SET @Resultado = 0
	  SET @mensaje = 'Esta producto esta relacionado a una Compra!'
	  END
    --SI EL PRODUCTO ESTA RELACIONADO A UNA VENTA--
	IF EXISTS (SELECT * FROM Detalle_Venta dv
	INNER JOIN producto p ON p.id_producto = dv.id_producto
	WHERE p.id_producto = @id_producto)

	  BEGIN
	  SET @validacion = 0
	  SET @Resultado = 0
	  SET @mensaje = 'Esta producto esta relacionado a una venta!'
	  END
	  --SI PASO LAS VALIDACIONES---
	  IF (@validacion = 1)
	  BEGIN
	     DELETE FROM producto
		 WHERE id_producto = @id_producto
		 SET @Resultado = 1
	  END
END;

--select * from producto
--select id_producto,codigo,Nombre,p.descripcion,c.id_categoria,c.descripcion[descripcion],stock,precio_compra,precio_venta,p.estado from producto p
--inner join categoria c on c.id_categoria = p.id_categoria

--insert into producto (codigo,Nombre,descripcion,id_categoria,estado) values(1,'Rizen 5','4.5ghz 8 nucleos 8 hilos',4,1)