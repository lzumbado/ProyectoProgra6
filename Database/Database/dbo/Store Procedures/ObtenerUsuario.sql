CREATE PROCEDURE [dbo].[ObtenerUsuario]
	  @UsuariosId int = NULL
AS BEGIN
  SET NOCOUNT ON

  SELECT 
      UsuariosId,
	 Usuario,
     Nombre
    FROM dbo.Usuario
    WHERE
    (@UsuariosId IS NULL OR UsuariosId=@UsuariosId)

END