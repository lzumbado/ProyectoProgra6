/*Author Ismael Umaña*/
CREATE PROCEDURE [dbo].[ActualizarCategoria]
    @IdCategoria int,
	@Categoria varchar(250)


AS BEGIN
SET NOCOUNT ON

  BEGIN TRANSACTION TRASA

    BEGIN TRY
	
	UPDATE dbo.Categorias SET
	 Categoria= @Categoria
	WHERE 
	       IdCategoria=@IdCategoria
	
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