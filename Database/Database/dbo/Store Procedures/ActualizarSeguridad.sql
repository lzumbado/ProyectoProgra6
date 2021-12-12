/*Author Ismael Umaña 10-12-2021*/
CREATE PROCEDURE [dbo].[ActualizarSeguridad]
	@IdSeguridad int,
    @NombreUsuario VARCHAR(250),
    @Usuario varchar(50),
    @Contrasena varchar(50)


AS BEGIN
SET NOCOUNT ON

  BEGIN TRANSACTION TRASA

    BEGIN TRY
	
	UPDATE dbo.Seguridad SET
	 NombreUsuario=@NombreUsuario,
	 Usuario=@Usuario,
	 Contrasena=@Contrasena
	WHERE 
	       IdSeguridad=@IdSeguridad
	
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