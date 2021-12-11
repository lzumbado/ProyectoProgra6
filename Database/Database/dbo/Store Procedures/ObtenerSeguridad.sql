CREATE PROCEDURE [dbo].[ObtenerSeguridad]
      @IdSeguridad int= NULL
AS BEGIN
  SET NOCOUNT ON

  SELECT 
     NombreUsuario,
	 Usuario,
     Contrasena
    FROM dbo.Seguridad
    WHERE
    (@IdSeguridad IS NULL OR IdSeguridad=@IdSeguridad)

END