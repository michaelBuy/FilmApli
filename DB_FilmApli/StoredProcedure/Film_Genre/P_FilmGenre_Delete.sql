CREATE PROCEDURE [dbo].[P_FilmGenre_Delete]
	@Id_Film_Genre INT
AS
BEGIN
	DELETE FROM Film_Genre
	WHERE Id_Film_Genre = @Id_Film_Genre
END
