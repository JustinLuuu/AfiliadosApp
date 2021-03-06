create database AFILIADOS_JUSTIN_MINAYA
go
use AFILIADOS_JUSTIN_MINAYA
go

CREATE TABLE Estatus(
	Id int primary key NOT NULL,
	Estatus varchar(8) unique NOT NULL
)

INSERT Estatus (Id, Estatus) VALUES (1, 'ACTIVO')
INSERT Estatus (Id, Estatus) VALUES (2, 'INACTIVO')


CREATE TABLE Planes(
	Id int primary key IDENTITY(1,1) NOT NULL,
	Nombre varchar(70) unique NOT NULL,
	Monto_Cobertura decimal(15, 0) NOT NULL,
	Fecha_Registro date NOT NULL,
	Id_Estatus int foreign key references Estatus(Id) NOT NULL
)


CREATE TABLE Afiliados (
	Id int primary key IDENTITY(1,1) NOT NULL,
	Nombres varchar(70) NOT NULL,
	Apellidos varchar(70) NOT NULL,
	Fecha_Nacimiento date NOT NULL,
	Sexo char(1) NOT NULL,
	Cedula varchar(14) unique NOT NULL,
	Numero_Seguridad_Social varchar(14) unique NOT NULL,
	Fecha_Registro date NOT NULL,
	Monto_Consumido decimal(15, 0) NOT NULL,
	Id_Estatus int foreign key references Estatus(Id) NOT NULL,
	Id_Plan int foreign key references Planes(Id) NOT NULL,
)
