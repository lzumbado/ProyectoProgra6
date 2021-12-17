CREATE PROCEDURE [dbo].[ObtenerCliente]
      @IdCliente int= NULL
AS BEGIN
  SET NOCOUNT ON

  SELECT 
     C.IdCliente,
	 C.Cedula,
	 C.Nombre,
	 C.Apellido1,
	 C.Apellido2,
	 C.Direccion,
	 C.Telefono,
	 C.FechaNacimiento  
    FROM dbo.Clientes C
    WHERE
    (@IdCliente IS NULL OR IdCliente=@IdCliente)

END