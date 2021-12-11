CREATE PROCEDURE [dbo].[ActualizarCliente]
    @IdCliente int,
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
	
	UPDATE dbo.Clientes SET
	 Cedula= @Cedula,
	 Nombre=@Nombre,
	 Apellido1=@Apellido1,
	 Apellido2= @Apellido2,
	 Direccion=@Direccion,
	 Telefono=@Telefono,
	 FechaNacimiento=@FechaNacimiento
	WHERE 
	       IdCliente=@IdCliente
	
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