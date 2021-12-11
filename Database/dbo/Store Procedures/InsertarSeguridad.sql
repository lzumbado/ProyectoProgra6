CREATE PROCEDURE [dbo].[InsertarSeguridad]
    @NombreUsuario VARCHAR(250),
    @Usuario varchar(50),
    @Contrasena varchar(50)

AS BEGIN
SET NOCOUNT ON

  BEGIN TRANSACTION TRASA

    BEGIN TRY
	
	INSERT INTO dbo.Seguridad
	(NombreUsuario,
	Usuario,
	Contrasena)
	VALUES
	(@NombreUsuario,
	@Usuario,
	@Contrasena)

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