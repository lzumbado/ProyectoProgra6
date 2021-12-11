CREATE TABLE [dbo].[Productos]
(
	IdProducto INT NOT NULL IDENTITY(1,1) CONSTRAINT PK_Producto PRIMARY KEY CLUSTERED(IdProducto),
	NombreProducto varchar(250) NOT NULL,
	Precio decimal,
	CantidadDisponible int,
	Caracteristicas varchar(250),
	Estado bit,
	IdCategoria int NOT NULL
	   CONSTRAINT FK_Productos_Categorias FOREIGN KEY(IdCategoria) REFERENCES dbo.Categorias(IdCategoria) 
	) WITH (DATA_COMPRESSION = PAGE)
GO