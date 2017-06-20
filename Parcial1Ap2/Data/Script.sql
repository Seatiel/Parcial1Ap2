create table Clientes(
ClienteId int identity(1,1) primary key,
FechaNacimiento date,
Nombres varchar(100),
CantidadTelefonos int
);