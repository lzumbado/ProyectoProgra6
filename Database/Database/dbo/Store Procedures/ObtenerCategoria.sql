﻿/*Author Ismael Umaña 10-12-2021*/
CREATE PROCEDURE [dbo].[ObtenerCategoria]
      @IdCategoria int= NULL
AS BEGIN
  SET NOCOUNT ON

  SELECT 
     IdCategoria,
	 Categoria
    FROM dbo.Categorias
    WHERE
    (@IdCategoria IS NULL OR IdCategoria=@IdCategoria)

END