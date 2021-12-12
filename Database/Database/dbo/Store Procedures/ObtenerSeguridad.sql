/*Author Ismael Umaña 10-12-2021*/
CREATE PROCEDURE [dbo].[ObtenerSeguridad]
      @IdSeguridad int= NULL
AS BEGIN
  SET NOCOUNT ON

  SELECT 
     IdSeguridad,
     NombreUsuario,
	 Usuario,
     Contrasena
    FROM dbo.Seguridad
    WHERE
    (@IdSeguridad IS NULL OR IdSeguridad=@IdSeguridad)

END