/*Author Ismael Umaña 10-12-2021*/
CREATE PROCEDURE [dbo].[ObtenerProducto]
      @IdProducto int= NULL
AS BEGIN
  SET NOCOUNT ON

  SELECT 
     P.IdProducto,
	 P.NombreProducto,
	 P.CantidadDisponible,
	 P.Caracteristicas,
	 P.Estado,
	 P.IdCategoria,

	 B.Categoria
	 
    FROM dbo.Productos P INNER JOIN dbo.Categorias B ON P.IdCategoria=B.IdCategoria
    WHERE
    (@IdProducto IS NULL OR IdProducto=@IdProducto)

END