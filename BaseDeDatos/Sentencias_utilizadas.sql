SELECT * FROM Usuario

SELECT * FROM Rol

INSERT INTO Rol(descripcion)
VALUES('Administrador')

INSERT INTO Usuario(DNI,Nombre_completo,Email,Pass,telefono,direccion,estado,id_rol)
VALUES ('40404040','Enzo','admin@gmail.com','123','3794111111','calle123',1,1)

INSERT INTO Usuario(DNI,Nombre_completo,Email,Pass,telefono,direccion,estado,id_rol)
VALUES ('40404040','Damian','vende@gmail.com','123','3794222222','calle456',1,2)

INSERT INTO Usuario(DNI,Nombre_completo,Email,Pass,telefono,direccion,estado,id_rol)
VALUES ('10101010','Fabian','super@gmail.com','123','3794333333','calle789',1,3)

INSERT INTO Rol(descripcion)
VALUES('Vendedor')


INSERT INTO Rol(descripcion)
VALUES('Supervisor')
