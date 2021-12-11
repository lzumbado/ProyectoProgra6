CREATE PROCEDURE [dbo].[ObtenerPedido]
      @IdPedido int
AS BEGIN
  SET NOCOUNT ON

  SELECT 
     A.IdPedido,
	 A.Envio,
     A.SubTotal,
     A.Impuesto,
     A.Total,
     A.FechaPedido,
     A.IdCliente,
     B.IdDetalle,
     B.Cantidad,
     B.IdProducto,
     C.Nombre,
     C.Apellido1,
     C.Apellido2,
     C.Telefono,
     P.NombreProducto,
     P.Precio
    FROM dbo.PedidoEncabezado A INNER JOIN dbo.PedidoDetalle B ON A.IdPedido=B.IdPedido,
     dbo.PedidoEncabezado AX INNER JOIN dbo.Clientes C ON AX.IdCliente=C.IdCliente,
     dbo.PedidoDetalle BX INNER JOIN dbo.Productos P ON BX.IdProducto=P.IdProducto
    WHERE
    (@IdPedido IS NULL OR A.IdPedido=@IdPedido)

END