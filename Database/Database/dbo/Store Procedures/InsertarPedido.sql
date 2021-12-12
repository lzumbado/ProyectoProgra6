﻿/*Author Ismael Umaña 10-12-2021*/
CREATE PROCEDURE [dbo].[InsertarPedido]
   @Envio Int,
   @SubTotal Int,
   @Impuesto Int,
   @Total Int,
   @FechaPedido date,
   @IdCliente int,
   @Cantidad int,
   @Precio decimal,
   @IdPedido int,
   @IdProducto int


AS BEGIN
SET NOCOUNT ON

  BEGIN TRANSACTION TRASA

    BEGIN TRY
	
	INSERT INTO dbo.PedidoEncabezado
	(Envio,
	SubTotal,
	Impuesto,
	Total,
	FechaPedido,
	IdCliente
	)
	VALUES
	(
    @Envio,
    @SubTotal,
    @Impuesto,
    @Total,
    @FechaPedido,
    @IdCliente
	)

	INSERT INTO dbo.PedidoDetalle
	(Cantidad,
	Precio,
	IdPedido,
	IdProducto
	)
	VALUES
	(
    @Cantidad,
	@Precio,
    @IdPedido,
    @IdProducto
	)

  COMMIT TRANSACTION TRASA
  SELECT 0 AS CodeError, '' AS MsgError

  END TRY

  BEGIN CATCH

   SELECT 
         ERROR_NUMBER() AS CodeError,
		 ERROR_MESSAGE() AS MsgError
   
   ROLLBACK TRANSACTION TRASA

   END CATCH

 END