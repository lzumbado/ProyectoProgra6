CREATE PROCEDURE [dbo].[ObtenerProducto]
      @IdProducto int= NULL
AS BEGIN
  SET NOCOUNT ON

  SELECT 
     P.IdProducto,
	 P.NombreProducto,
	 P.Precio,
	 P.CantidadDisponible,
	 P.Caracteristicas,
	 P.Estado,
	 P.IdCategoria
    FROM dbo.Productos P
    WHERE
    (@IdProducto IS NULL OR IdProducto=@IdProducto)

END