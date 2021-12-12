/*Author Ismael Umaña 10-12-2021*/
CREATE TABLE [dbo].[Seguridad]
(
	[IdSeguridad] INT NOT NULL IDENTITY(1,1) CONSTRAINT PK_Seguridad PRIMARY KEY CLUSTERED(IdSeguridad)
   ,NombreUsuario VARCHAR(250) NOT NULL,
   Usuario varchar(50) NOT NULL,
   Contrasena varchar(50) NOT NUll
)
