/*Author Ismael Umaña 10-12-2021*/
CREATE PROCEDURE [dbo].[ActualizarProducto]
    @IdProducto int,
	@NombreProducto varchar(250),
	@CantidadDisponible Int,
	@Caracteristicas varchar(250),
	@Estado bit,
	@IdCategoria int

AS BEGIN
SET NOCOUNT ON

  BEGIN TRANSACTION TRASA

    BEGIN TRY
	
	UPDATE dbo.Productos SET
	 NombreProducto=@NombreProducto,
	 CantidadDisponible=@CantidadDisponible,
	 Caracteristicas=@Caracteristicas,
	 Estado=@Estado,
	 IdCategoria=@IdCategoria
	WHERE 
	       IdProducto=@IdProducto
	
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