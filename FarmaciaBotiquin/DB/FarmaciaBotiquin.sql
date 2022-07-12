CREATE DATABASE Farmacia_Botiquin
USE Farmacia_Botiquin

Create table Estado
(
	IdEstado int identity primary key,
	Estado char(8) not null unique
);
Create table Puesto
(
	IdPuesto int identity primary key,
	Puesto nvarchar(15) not null unique
);
Create table Empleado
(
	IdEmpleado int identity primary key,
	NombreEmpleado nvarchar(30) not null,
	ApellidoEmpleado nvarchar(30) not null,
	Email nvarchar(25) unique not null,
	Telefono char(8) unique null,
	IdPuesto int not null,
	IdEstado int not null,
	CONSTRAINT Fk_Empleado_Puesto Foreign key (IdPuesto)
		References Puesto(IdPuesto),
	CONSTRAINT Fk_Empleado_Estado Foreign key (IdEstado)
		References Estado(IdEstado)
);
Create table Usuario
(
	IdUsuario int identity primary key,
	Usuario nvarchar(25) unique not null,
	Contra nvarchar(20) not null,
	IdEmpleado int not null,
	IdEstado int not null,
	CONSTRAINT Fk_Usuario_Empleado Foreign key (IdEmpleado)
		References Puesto(IdPuesto),
	CONSTRAINT Fk_Usuario_Estado Foreign key (IdEstado)
		References Estado(IdEstado)
);
Create table Cliente
(
	IdCliente int identity primary key,
	DNICliente nvarchar(13) not null unique,
	NombreCliente nvarchar(30) not null,
	ApellidoCliente nvarchar(30) not null,
	Email nvarchar(25) unique,
	FechaNacimiento datetime not null,
	IdEstado int not null
	Constraint Fk_Cliente_Estado foreign key(IdEstado)
		References Estado(IdEstado)
);
Create table Proveedor
(
	CodProveedor nvarchar(13) primary key,
	RTN nvarchar(14) unique not null,
	NombreProveedor nvarchar(30) unique not null,
	Telefono char(8) unique,
	Email nvarchar(25),
	Direccion nvarchar(50),
	IdEstado int not null
	Constraint Fk_Proveedor_Estado foreign key(IdEstado)
		References Estado(IdEstado)
);
Create table Producto 
(
	CodProducto nvarchar(20) primary key,
	NombreProducto nvarchar(30) unique not null,
	Descripcion nvarchar(40) not null,
	Existencia int not null,
	FechaVencimiento date not null,
	IdEstado int not null
	Constraint Fk_Producto_Estado foreign key(IdEstado)
		References Estado(IdEstado)
);
Create table Factura
(
	IdFactura int primary key identity,
	IdEmpleado int not null,
	IdCliente int not null,
	Fecha datetime not null,
	FechaVencimiento datetime not null,
	Total float not null,
	Constraint Fk_Factura_Empleado foreign key(IdEmpleado)
		References Empleado(IdEmpleado),
	Constraint Fk_Factura_Cliente foreign key(Idcliente)
		References Cliente(IdCliente)
);
Create table DetalleFactura
(
	Id_Detall_Factura int identity primary key,
	IdFactura int not null,
	CodProducto nvarchar(20) not null,
	Cantidad int not null,
	Precio float not null,
	Constraint Fk_DetalleFactura_Factura foreign key(IdFactura)
		References Factura(IdFactura),
	Constraint Fk_DetalleFactura_Producto foreign key(CodProducto)
		References Producto(CodProducto)
);

--Datos para probar la base de datos
--================================================================================================
--Tabla de ESTADO
Insert into Estado
values('Activo')
Insert into Estado
values('Inactivo')
--================================================================================================
--Tabla de PUESTO
Insert into Puesto
values('Gerente')
Insert into Puesto
values('Administrador')
Insert into Puesto
values('Personal')
--================================================================================================
--Tabla de EMPLEADO
Insert into Empleado
values('Hader Obed', 'Mendez', 'hader.mendez@gmail.com', '89188022', 2, 1) --administrador
Insert into Empleado
values('Jordi', 'Martinez', 'ejemplo1@gmail.com', '00000001', 1, 1) --gerente
Insert into Empleado
values('Josue David', 'Lainez', 'ejemplo2@gmail.com', '00000002', 3, 1) --personal
--================================================================================================
--Tabla de USUARIO
Insert into Usuario
values('Hmendez', 'Admin123', 1, 1)
--================================================================================================


--Procedimientos almacenados
alter procedure Sp_Usuario
@IdUsuario int = null,
@Usuario nvarchar(25) = null,
@Contra nvarchar(25) = null,
@IdEmpleado int = null,
@IdEstado int = null,
@accion nvarchar(50)
AS
BEGIN
	if @accion = 'obtenerUsuario'
	BEGIN
		SELECT U.IdUsuario, U.Usuario, U.Contra, U.IdEmpleado, U.IdEstado
		FROM Usuario U
		where U.Usuario = @Usuario
	END
End

alter Procedure Sp_Empleados
@IdEmpleado int = null,
@NombreEmpleado nvarchar(30) = null,
@ApellidoEmpleado nvarchar(30) = null,
@Email nvarchar(25) = null,
@Telefono char(8) = null,
@IdPuesto int = null,
@IdEstado int = null,
@accion nvarchar(50),
@BuscarEmpleado nvarchar(50) = null
As
Begin
	if @accion = 'mostrar'
	Begin
		Select E.IdEmpleado, E.NombreEmpleado as 'Nombre', E.ApellidoEmpleado as 'Apellido', E.Email, E.Telefono, P.Puesto, EE.Estado
		From Empleado E
		Inner Join Puesto P
		On P.IdPuesto = E.IdPuesto
		Inner Join Estado EE
		on EE.IdEstado = E.IdEstado
	End
	else if @accion = 'buscar'
	BEGIN
		SELECT E.NombreEmpleado as 'Nombre', E.ApellidoEmpleado as 'Apellido', E.Email, E.Telefono, P.Puesto, EE.Estado
		FROM Empleado E
		Inner JOIN Puesto P
		ON P.IdPuesto = E.IdPuesto
		inner join Estado EE
		On EE.IdEstado = E.IdEstado
		WHERE  CONCAT(E.NombreEmpleado, ' ', E.ApellidoEmpleado, ' ', E.Email, ' ', E.Telefono, ' ', P.Puesto) LIKE CONCAT('%', @BuscarEmpleado,'%')
	END
	ELSE IF @accion = 'obtenerTelefono'
	BEGIN
		SELECT IdEmpleado as 'ID', CONCAT(NombreEmpleado, ' ' , ApellidoEmpleado) as 'Empleados', Email as 'Correo', Telefono, IdPuesto as 'Puesto', IdEstado as 'Estado'
		FROM Empleado 
		WHERE Telefono = @Telefono
	END
	ELSE IF @accion = 'obtenerCorreo'
	BEGIN
		SELECT IdEmpleado as 'ID', CONCAT(NombreEmpleado, ' ' , ApellidoEmpleado) as 'Empleados', Email as 'Correo', Telefono, IdPuesto as 'Puesto', IdEstado as 'Estado'
		FROM Empleado
		WHERE Email = @Email
	END
	Else IF @accion = 'insertar'
	BEGIN
		INSERT INTO Empleado
		VALUES(@NombreEmpleado, @ApellidoEmpleado, @Email, @Telefono, @IdPuesto, @IdEstado)
	END
	ELSE IF @accion = 'editar'
	BEGIN
		UPDATE Empleado
		SET NombreEmpleado = @NombreEmpleado, ApellidoEmpleado = @ApellidoEmpleado, Email = @Email,Telefono = @Telefono,IdPuesto = @IdPuesto, IdEstado = @IdEstado
		WHERE IdEmpleado = @IdEmpleado
	END
End

Create procedure Sp_Puesto
@IdPuesto int = null,
@Puesto nvarchar(15) = null,
@accion nvarchar(50)
as
begin
	IF @accion = 'mostrar'
	BEGIN
		SELECT  P.IdPuesto, P.Puesto
		FROM Puesto P
		ORDER BY P.Puesto ASC
	END
end

Create Procedure Sp_Estado
@IdEstado int = null,
@Estado char(8) = null,
@accion nvarchar(50)
As
Begin
	IF @accion = 'mostrar'
	BEGIN
		SELECT  E.IdEstado, E.Estado
		FROM Estado E
		ORDER BY E.Estado ASC
	END
End