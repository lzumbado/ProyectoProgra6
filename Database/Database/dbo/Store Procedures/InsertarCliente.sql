/*Author Ismael Umaña 10-12-2021*/
CREATE PROCEDURE [dbo].[InsertarCliente]
	@Cedula Int,
	@Nombre varchar(50),
	@Apellido1 varchar(50),
	@Apellido2 varchar(50),
	@Direccion varchar(250),
	@Telefono  varchar(8),
	@FechaNacimiento Date

AS BEGIN
SET NOCOUNT ON

  BEGIN TRANSACTION TRASA

    BEGIN TRY
	
	INSERT INTO dbo.Clientes
	(Cedula,
	Nombre,
	Apellido1,
	Apellido2,
	Direccion,
	Telefono,
	FechaNacimiento
	)
	VALUES
	(
	@Cedula,
	@Nombre,
	@Apellido1,
	@Apellido2,
	@Direccion,
	@Telefono,
	@FechaNacimiento
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