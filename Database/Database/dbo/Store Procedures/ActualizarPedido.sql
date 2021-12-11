CREATE PROCEDURE [dbo].[ActualizarPedido]
   @Envio Int,
   @SubTotal Int,
   @Impuesto Int,
   @Total Int,
   @FechaPedido date,
   @IdCliente int,
   @Cantidad int,
   @IdPedido int,
   @IdProducto int


AS BEGIN
SET NOCOUNT ON

  BEGIN TRANSACTION TRASA

    BEGIN TRY
	
	UPDATE dbo.PedidoEncabezado SET
	 Envio=@Envio,
	 SubTotal=@SubTotal,
	 Impuesto=@Impuesto,
	 Total=@Total,
	 FechaPedido=@FechaPedido,
	 IdCliente=@IdCliente
	WHERE 
	       IdPedido=@IdPedido

	UPDATE dbo.PedidoDetalle SET
	 Cantidad=@Cantidad,
	 IdProducto=@IdProducto
	WHERE 
	       IdPedido=@IdPedido
	
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