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
	  set @mensaje = 'No se puede repetir el numero de documento para más de un usuario'
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
	    -- Inserción del nuevo producto
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


/**********************CLIENTES*************************/

---REGISTRAR CIENTES

CREATE PROCEDURE sp_registrar_cliente(
@DNI int,
@NombreCompleto varchar(100),
@Email varchar(100),
@Telefono varchar(100),
@Direccion varchar(100),
@CodigoPostal varchar(100),
@Ciudad varchar(100),
@Localidad varchar(100),
@Estado bit,
@Resultado int output,
@Mensaje varchar(100) output

)as

BEGIN 
     SET @Resultado = 0
	 DECLARE @idpersona INT 
	 IF NOT EXISTS (SELECT * FROM Cliente WHERE DNI = @DNI)
	 BEGIN
	      INSERT INTO Cliente (DNI,Nombre_completo,Email,telefono,direccion,codigo_postal,ciudad,estado,localidad)
		  VALUES(@DNI,@NombreCompleto,@Email,@Telefono,@Direccion,@CodigoPostal,@Ciudad,@Estado,@Localidad)

		  SET @Resultado = SCOPE_IDENTITY()
		  END
		  ELSE
		      SET @Mensaje = 'El  numero de DNI ya existe'
END


---MOIDIFICAR CLIENTES

CREATE PROCEDURE sp_modificar_cliente(
@id_cliente int,
@DNI int,
@NombreCompleto varchar(100),
@Email varchar(100),
@Telefono varchar(100),
@Direccion varchar(100),
@CodigoPostal varchar(100),
@Ciudad varchar(100),
@Localidad varchar(100),
@Estado bit,
@Resultado int output,
@Mensaje varchar(100) output
)as
BEGIN 
     SET @Resultado = 1
	 DECLARE @idpersona int
	 IF NOT EXISTS(SELECT * FROM Cliente WHERE DNI = @DNI AND id_cliente != @id_cliente)
	 BEGIN 
	      UPDATE Cliente SET
		  DNI = @DNI,
		  Nombre_completo = @NombreCompleto,
		  Email = @Email,
		  telefono = @Telefono,
		  direccion = @Direccion,
		  codigo_postal = @CodigoPostal,
		  ciudad = @Ciudad,
		  localidad = @Localidad,
		  estado = @Estado
		  WHERE id_cliente = @id_cliente
	END
	ELSE
	BEGIN
	     SET @Resultado = 0
		 SET @Mensaje = 'El numero de DNI ya existe'
    END
END


--insert into Cliente(DNI,Nombre_completo,Email,telefono,direccion,codigo_postal,ciudad,estado,localidad)
--values(50555666,'Jorge Luis','jorch@gmail.comn','3794685739','calle543','3400','Corrientes',1,'Mercedes')


/*************************PROVEEDORES**************************/

---REGISTRAR PROVEEDOR

CREATE PROCEDURE sp_registrar_proveedor(
@DNI int,
@RazonSocial varchar(100),
@Email varchar(100),
@Telefono varchar(100),
@Direccion varchar(100),
@CodigoPostal varchar(100),
@Ciudad varchar(100),
@Estado bit,
@Resultado int output,
@Mensaje varchar(100) output
)as
BEGIN 
     SET @Resultado = 0
	 DECLARE @idpersona INT
	 IF NOT EXISTS (SELECT  * FROM Proveedor WHERE DNI = @DNI)
	 BEGIN 
	      INSERT INTO Proveedor(DNI,Razon_social,Email,Telefono,direccion,ciudad,codigo_postal,estado)
		  VALUES (@DNI,@RazonSocial,@Email,@Telefono,@Direccion,@Ciudad,@CodigoPostal,@Estado)

		  SET @Resultado = SCOPE_IDENTITY()
     END
	 ELSE
	     SET @Mensaje = 'El número de documento ya existe'
END

---EDITAR PROVEEDOR

CREATE PROCEDURE sp_editar_proveedor(
@Idproveedor int,
@DNI int,
@RazonSocial varchar(100),
@Email varchar(100),
@Telefono varchar(100),
@Direccion varchar(100),
@CodigoPostal varchar(100),
@Ciudad varchar(100),
@Estado bit,
@Resultado int output,
@Mensaje varchar(100) output
)as
BEGIN 
     SET @Resultado = 1
	 DECLARE @idpersona INT
	 IF NOT EXISTS (SELECT  * FROM Proveedor WHERE DNI = @DNI AND id_proveedor != @Idproveedor)
	 BEGIN 
	      UPDATE Proveedor SET
		  DNI = @DNI,
		  Razon_social = @RazonSocial,
		  Email = @Email,
		  Telefono = @Telefono,
		  direccion = @Direccion,
		  codigo_postal = @CodigoPostal,
		  ciudad = @Ciudad,
		  estado = @Estado
		  WHERE id_proveedor = @Idproveedor
	 END
	 ELSE
	    BEGIN
		  SET @Resultado = 0
	      SET @Mensaje = 'El número de documento ya existe'
	    END
END


---ELIMINAR PROVEEDOR

CREATE PROCEDURE sp_eliminar_proveedor(
@Idproveedor int,
@Resultado bit output,
@Mensaje varchar(100) output
)
as
BEGIN 
     SET @Resultado = 1
	 IF NOT EXISTS (
	 SELECT * FROM Proveedor p
	 inner join Compra c on p.id_proveedor = c.id_proveedor
	 WHERE p.id_proveedor = c.id_proveedor
	 )
	 BEGIN 
	      DELETE TOP (1) FROM  Proveedor 
		  WHERE id_proveedor = @Idproveedor
	 END
	 ELSE
	     BEGIN
		      SET @Resultado = 0
			  SET @Mensaje = 'No es posible eliminar este proveedor'
		 END
END

--select * from Proveedor

--INSERT INTO Proveedor(DNI,Razon_social,Email,Telefono,direccion,ciudad,codigo_postal,estado)
--VALUES (40222333,'AMD,inc','admsuppots@gmail.com','0800-xxx-xxx','calle000','Corrientes Capital','4444',1)



/*********PROCEDIMIENTO PARA REGISTRAR UNA COMPRA**************/
--DROP TYPE dbo.EDetalleCompra;

CREATE TYPE[dbo].[EDetalleCompra] AS TABLE(
[Idproducto] int NULL,
[PrecioCompra] decimal(10,2) null,
[PrecioVenta] decimal (10,2) null,
[Cantidad] int null,
[MontoTotal] decimal (10,2) null
)

go

CREATE PROCEDURE sp_registrar_compra(
@Idusuario int,
@Idproveedor int,
@Tipofactura varchar(50),
@Numerofactura varchar(100),
@MontoTotal decimal (10,2),
@DetalleCompra [EDetalleCompra] READONLY,
@Resultado bit output,
@Mensaje varchar(100) output		
)
AS BEGIN

        BEGIN TRY
		         DECLARE @Idcompra int = 0
				 SET @Resultado = 1
				 SET @Mensaje = ''

				 begin transaction registro
				 insert into Compra(tipoDe_factura,numeroDe_factura,montoTotal,id_proveedor,id_usuario)
				 values(@Tipofactura,@Numerofactura,@MontoTotal,@Idproveedor,@Idusuario)

				 set @Idcompra = SCOPE_IDENTITY()--devuelve el ultimo id generado en compra 

				 insert into Detalle_Compra(precioCompra,precioVenta,cantidad,monto_total,id_compra,id_producto)
				 select PrecioCompra,PrecioVenta,Cantidad,MontoTotal,@Idcompra,Idproducto from @DetalleCompra

				 update p set p.stock = p.stock + dc.cantidad,
				 p.precio_compra = dc.PrecioCompra,
				 p.precio_venta = dc.PrecioVenta
				 from producto p
				 inner join @DetalleCompra dc ON dc.Idproducto = p.id_producto

				 commit transaction registro
		END TRY

		BEGIN CATCH
		           SET @Resultado = 0 
				   SET @Mensaje = ERROR_MESSAGE()
		           rollback transaction registro
		END CATCH
END


--select * from Compra
--select * from Detalle_Compra
--select * from Usuario


/*********************DETALLE DE COMPRA*******************/

--SELECT c.id_compra,c.tipoDe_factura,c.numeroDe_factura,c.montoTotal,convert(char(10),c.fecha_registro,103)[fecha_registro],
--u.Nombre_completo,
--pr.DNI,pr.Razon_social
--FROM Compra c
--INNER JOIN Usuario u on u.id_usuario = c.id_usuario
--INNER JOIN Proveedor pr on pr.id_proveedor = c.id_proveedor
--where c.numeroDe_factura = 00001

--SELECT p.Nombre,
--dc.precioCompra,dc.cantidad,dc.monto_total
--FROM Detalle_Compra dc
--INNER JOIN producto p on p.id_producto = dc.id_producto 
--where dc.id_compra = 15


/*********PROCEDIMIENTO PARA REGISTRAR UNA VENTA**************/
--DROP TYPE dbo.EDetalleVenta;

CREATE TYPE[dbo].[EDetalleVenta] AS TABLE(
[Idproducto] int NULL,
[PrecioVenta] decimal (10,2) null,
[Cantidad] int null,
[MontoTotal] decimal (10,2) null
)
CREATE PROCEDURE sp_registrar_venta(
@Idusuario int,
@Tipofactura varchar(50),
@Numerofactura varchar(100),
@DNIcliente varchar(100),
@NombreCliente varchar(100),
@MontoPago decimal (10,2),
@MontoCambio decimal(10,2),
@MontoTotal decimal (10,2),
@DetalleVenta [EDetalleVenta] READONLY,
@Resultado bit output,
@Mensaje varchar(100) output		
)
AS BEGIN

        BEGIN TRY
		         DECLARE @Idventa int = 0
				 SET @Resultado = 1
				 SET @Mensaje = ''

				 begin transaction registro

				 insert into Venta(tipoDe_factura,DNI_cliente,Nombre_cliente,Monto_pago,Monto_cambio,Monto_Total,id_usuario,numeroDe_factura)
				 values(@Tipofactura,@DNIcliente,@NombreCliente,@MontoPago,@MontoCambio,@MontoTotal,@Idusuario,@Numerofactura)

				 set @Idventa = SCOPE_IDENTITY()--devuelve el ultimo id generado en tabla venta 

				 insert into Detalle_Venta(precioVenta,cantidad,subTotal,id_venta,id_producto)
				 select PrecioVenta,Cantidad,MontoTotal,@Idventa,Idproducto from @DetalleVenta

				 commit transaction registro
		END TRY

		BEGIN CATCH
		           SET @Resultado = 0 
				   SET @Mensaje = ERROR_MESSAGE()
		           rollback transaction registro
		END CATCH
END


--select * from Venta
--select * from Detalle_Venta


--update producto set stock = stock - @Cantidad where id_producto = @Idproducto
--select * from Venta