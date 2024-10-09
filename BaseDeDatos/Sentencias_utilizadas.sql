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





