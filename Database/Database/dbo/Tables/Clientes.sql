/*Author Ismael Umaña 10-12-2021*/
CREATE TABLE [dbo].[Clientes]
(
	IdCliente INT NOT NULL IDENTITY(1,1) CONSTRAINT PK_Cliente PRIMARY KEY CLUSTERED(IdCliente),
	Cedula INT UNIQUE NOT NULL,
	Nombre varchar(50) NOT NULL,
	Apellido1 varchar(50) NOT NULL,
	Apellido2 varchar(50) NOT NULL,
	Direccion varchar(250) NOT NULL,
	Telefono  varchar(8) NOT NULL,
	FechaNacimiento Date
	   
)WITH (DATA_COMPRESSION = PAGE)
GO