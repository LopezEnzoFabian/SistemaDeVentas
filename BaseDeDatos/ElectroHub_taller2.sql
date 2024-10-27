CREATE DATABASE Electrohub_Taller2
GO

USE Electrohub_Taller2
go

--BASE DE DATOS DE SISTEMAS DE VENTAS PARA TALLER 2
--TABLAS CORRESPONDIENTES A LOS DATOS QUE SE VAN A UTILIZAR

CREATE TABLE Rol
(
  id_rol INT IDENTITY,
  descripcion VARCHAR(50) NOT NULL,
  fecha_registro DATETIME DEFAULT GETDATE(),
  CONSTRAINT PK_id_rol PRIMARY KEY (id_rol)
);

CREATE TABLE Permiso
(
  id_permiso INT IDENTITY,
  Nombre_menu VARCHAR(100) NOT NULL,
  fecha_registro DATETIME DEFAULT GETDATE(),
  id_rol INT NOT NULL,
  CONSTRAINT PK_id_permiso PRIMARY KEY (id_permiso),
  CONSTRAINT FK_id_rol FOREIGN KEY (id_rol) REFERENCES Rol(id_rol),
);


CREATE TABLE Proveedor
(
  id_proveedor INT IDENTITY,
  DNI VARCHAR(100) NOT NULL,
  Razon_social VARCHAR(100) NOT NULL,
  Email VARCHAR(100) NOT NULL,
  Telefono VARCHAR(100),
  direccion VARCHAR(100) NOT NULL,
  ciudad VARCHAR(100) NOT NULL,
  codigo_postal VARCHAR(100),
  estado bit,
  fecha_registro DATETIME DEFAULT GETDATE(),
  CONSTRAINT PK_id_proveedor PRIMARY KEY (id_proveedor),
  CONSTRAINT UK_email UNIQUE(Email)
);

CREATE TABLE categoria
(
  id_categoria INT IDENTITY,
  descripcion VARCHAR(100) NOT NULL,
  estado bit,
  fecha_registro DATETIME DEFAULT GETDATE(),
  CONSTRAINT PK_id_categoria PRIMARY KEY (id_categoria)
);


CREATE TABLE producto
(
  id_producto INT IDENTITY,
  codigo VARCHAR(100),
  Nombre VARCHAR(100) NOT NULL,
  descripcion VARCHAR(100) NOT NULL,
  stock INT DEFAULT 0,
  precio_compra DECIMAL(10,2) DEFAULT 0,
  precio_venta DECIMAL(10,2) DEFAULT 0,
  estado bit,
  fecha_registro DATETIME DEFAULT GETDATE(),
  id_categoria INT,
  CONSTRAINT PK_id_producto PRIMARY KEY (id_producto),
  CONSTRAINT FK_prod_id_categoria FOREIGN KEY (id_categoria) REFERENCES categoria(id_categoria)
);


CREATE TABLE Cliente
(
  id_cliente INT IDENTITY,
  DNI VARCHAR(100) NOT NULL,
  Nombre_completo VARCHAR(100) NOT NULL,
  Email VARCHAR(100) NOT NULL,
  telefono VARCHAR(100),
  direccion VARCHAR(100),
  codigo_postal VARCHAR(100),
  ciudad VARCHAR(100) NOT NULL,
  estado bit,
  fecha_registro DATETIME DEFAULT GETDATE(),
  CONSTRAINT PK_id_cliente PRIMARY KEY (id_cliente),
);


CREATE TABLE Usuario
(
  id_usuario INT IDENTITY,
  DNI VARCHAR(100),
  Nombre_completo VARCHAR(100) NOT NULL,
  Email VARCHAR(100) NOT NULL,
  Pass VARCHAR(100) NOT NULL,
  telefono VARCHAR(100),
  direccion VARCHAR(100),
  estado bit,
  fecha_registro DATETIME DEFAULT GETDATE(),
  id_rol INT,
  CONSTRAINT PK_id_usuario PRIMARY KEY (id_usuario),
  CONSTRAINT FK_usuario_id_rol FOREIGN KEY (id_rol) REFERENCES Rol(id_rol),
);



CREATE TABLE Venta
(
  id_venta INT IDENTITY,
  tipoDe_factura VARCHAR(50) NOT NULL,
  numeroDe_factura INT NOT NULL,
  DNI_cliente VARCHAR(100),
  Nombre_cliente VARCHAR(100) NOT NULL,
  Monto_pago DECIMAL(10,2),
  Monto_cambio DECIMAL(10,2),
  Monto_Total DECIMAL(10,2),
  fecha_registro DATETIME DEFAULT GETDATE(),
  id_cliente INT NOT NULL,
  id_usuario INT NOT NULL,
  CONSTRAINT PK_id_venta PRIMARY KEY (id_venta),
  CONSTRAINT FK_id_cliente FOREIGN KEY (id_cliente) REFERENCES Cliente(id_cliente),
  CONSTRAINT FK_id_usuario FOREIGN KEY (id_usuario) REFERENCES Usuario(id_usuario)
);

CREATE TABLE Compra
(
  id_compra INT IDENTITY,
  tipoDe_factura VARCHAR(50) NOT NULL, --Factura ordinaria ,Factura rectificativa,Factura recapitulativa,Factura proforma,Factura electrónica
  numeroDe_factura VARCHAR(50),
  montoTotal DECIMAL(10,2),
  fecha_registro DATETIME DEFAULT GETDATE(),
  id_proveedor INT NOT NULL,
  id_usuario INT NOT NULL,
  CONSTRAINT PK_id_compra PRIMARY KEY (id_compra),
  CONSTRAINT FK_id_proveedor FOREIGN KEY (id_proveedor) REFERENCES Proveedor(id_proveedor),
  CONSTRAINT FK_compra_id_usuario FOREIGN KEY (id_usuario) REFERENCES Usuario(id_usuario)
);


CREATE TABLE Detalle_Compra
(
  id_detalle_compra INT IDENTITY,
  precioCompra DECIMAL(10,2) DEFAULT 0,
  precioVenta DECIMAL(10,2) DEFAULT 0,
  cantidad INT NOT NULL,
  monto_total DECIMAL(10,2),
  fecha_registro DATETIME DEFAULT GETDATE(),
  id_compra INT NOT NULL,
  id_producto INT NOT NULL,
  CONSTRAINT PK_id_detalle_compra PRIMARY KEY (id_detalle_compra),
  CONSTRAINT FK_DC_id_compra FOREIGN KEY (id_compra) REFERENCES Compra(id_compra),
  CONSTRAINT FK_DC_id_producto FOREIGN KEY (id_producto) REFERENCES producto(id_producto)
);

CREATE TABLE Detalle_Venta
(
  id_detalle_venta INT IDENTITY,
  precioVenta DECIMAL(10,2) DEFAULT 0,
  cantidad INT NOT NULL,
  subTotal DECIMAL(10,2) DEFAULT 0,
  fecha_registro DATETIME DEFAULT GETDATE(),
  id_venta INT NOT NULL,
  id_producto INT NOT NULL,
  CONSTRAINT PK_id_detalle_venta PRIMARY KEY (id_detalle_venta),
  CONSTRAINT FK_DV_id_venta FOREIGN KEY (id_venta) REFERENCES Venta(id_venta),
  CONSTRAINT FK_DV_id_prodcuto FOREIGN KEY (id_producto) REFERENCES producto(id_producto)
);