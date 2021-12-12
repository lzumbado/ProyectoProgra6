/*Author Ismael Umaña 10-12-2021*/
CREATE TABLE [dbo].[PedidoDetalle]
(
	[IdDetalle] INT NOT NULL IDENTITY(1,1) CONSTRAINT PK_PedidoDetalle PRIMARY KEY CLUSTERED(IdDetalle)
   ,Cantidad Int,
	IdPedido int NOT NULL
	   CONSTRAINT FK_PedidoDetalle_PedidoEncabezado FOREIGN KEY(IdPedido) REFERENCES dbo.PedidoEncabezado(IdPedido),
	IdProducto int NOT NULL
	   CONSTRAINT FK_PedidoDetalle_Productos FOREIGN KEY(IdProducto) REFERENCES dbo.Productos(IdProducto) 	   
	) WITH (DATA_COMPRESSION = PAGE)