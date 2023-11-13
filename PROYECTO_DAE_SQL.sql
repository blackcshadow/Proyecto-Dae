CREATE DATABASE TiendaClaudia;
go

USE TiendaClaudia;
go

CREATE TABLE Usuarios(
	id_Usuario INT not null IDENTITY(1,1) CONSTRAINT pk_id_Usuario PRIMARY KEY,
	Nombre VARCHAR (50) not null,
	Usuario VARCHAR (50) not null,
	Contrasenia VARCHAR (50)not null,
	Tipo_usuario VARCHAR (50)
);
go
INSERT INTO Usuarios(Nombre,Usuario,Contrasenia,Tipo_usuario) VALUES
('Manrique Recinos','Manrex','123', 'Administrador'),
('Gerardo Gonzalez','Alexis','321', 'Usuario');
go

CREATE TABLE Categoria(
id_Categoria INT NOT NULL IDENTITY(1,1) CONSTRAINT pk_categoria PRIMARY KEY,
Nombrecatego varchar(50) not null,
);
go
CREATE TABLE Descuento(
id_Descuento INT NOT NULL IDENTITY(1,1) CONSTRAINT pk_descuento PRIMARY KEY,
Descuento varchar(10) null
);
go
CREATE TABLE Proveedor(
id_Proveedor INT NOT NULL IDENTITY(1,1) CONSTRAINT pk_proveedor PRIMARY KEY,
Nombre varchar(50) not null,
Direccion varchar(50) not null,
Telefono int not null
);
go
CREATE TABLE Pedido(
id_Pedido INT NOT NULL IDENTITY(1,1) CONSTRAINT pk_pedido PRIMARY KEY,
Fecha_pedido varchar(50) not null,
Totalpedido money not null,
id_Proveedor INT NOT NULL CONSTRAINT fk_proveedor FOREIGN KEY (id_Proveedor) REFERENCES Proveedor(id_Proveedor)
);
go
CREATE TABLE Producto(
id_Producto INT NOT NULL IDENTITY(1,1) CONSTRAINT pk_producto PRIMARY KEY,
Precio money not null,
Nombre varchar(50) not null,
cantidad int not null,
id_Categoria INT NOT NULL CONSTRAINT fk_categoria FOREIGN KEY (id_Categoria) REFERENCES Categoria(id_Categoria),
id_Pedido INT NOT NULL CONSTRAINT fk_pedido FOREIGN KEY (id_Pedido) REFERENCES Pedido(id_Pedido)
);
go
CREATE TABLE Factura(
id_Factura INT NOT NULL IDENTITY(1,1) CONSTRAINT pk_factura PRIMARY KEY,
TotalBruto money not null,
TotalFinal money not null,
IVA money not null,
id_Descuento int not null CONSTRAINT fk_descuento FOREIGN KEY (id_Descuento) REFERENCES Descuento(id_Descuento)
);
go
CREATE TABLE DetalleVenta(
id_Detaventa INT NOT NULL IDENTITY(1,1) CONSTRAINT pk_detaventa PRIMARY KEY,
Cliente varchar(80) not null,
Total money not null,
id_Usuario int not null CONSTRAINT fk_usuario FOREIGN KEY (id_Usuario) REFERENCES Usuarios(id_Usuario),
id_Factura int not null CONSTRAINT fk_factura FOREIGN KEY (id_Factura) REFERENCES Factura(id_Factura)
);
go


