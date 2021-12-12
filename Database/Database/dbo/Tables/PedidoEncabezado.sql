/*Author Ismael Umaña 10-12-2021*/
CREATE TABLE [dbo].[PedidoEncabezado]
(
	[IdPedido] INT NOT NULL IDENTITY(1,1) CONSTRAINT PK_PedidoEncabezado PRIMARY KEY CLUSTERED(IdPedido)
   ,Envio Int,
   SubTotal Int,
   Impuesto Int,
   Total Int,
   FechaPedido date,
	IdCliente int NOT NULL
	   CONSTRAINT FK_Clientes_PedidoEncabezado FOREIGN KEY(IdCliente) REFERENCES dbo.Clientes(IdCliente) 
	) WITH (DATA_COMPRESSION = PAGE)