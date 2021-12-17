CREATE PROCEDURE [dbo].[InsertarProducto]
	@NombreProducto varchar(250),
	@CantidadDisponible int,
	@Caracteristicas varchar(250),
	@Estado bit,
	@IdCategoria int

AS BEGIN
 SET NOCOUNT ON

  BEGIN TRANSACTION TRASA

    BEGIN TRY
	
	INSERT INTO dbo.Productos
	(NombreProducto,
	CantidadDisponible,
	Caracteristicas,
	Estado,
	IdCategoria
	)
	VALUES
	(
	@NombreProducto,
	@CantidadDisponible,
	@Caracteristicas,
	@Estado,
	@IdCategoria
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