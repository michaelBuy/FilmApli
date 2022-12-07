CREATE PROCEDURE [dbo].[P_FilmGenre_Update]
	@Id_Film_Genre INT,
	@PEGI_Film_Genre INT,
	@Id_Film INT,
	@Id_Genre INT
AS
BEGIN
	UPDATE Film_Genre
	SET PEGI_Film_Genre = @PEGI_Film_Genre, Id_Film = @Id_Film, Id_Genre = @Id_Genre
	WHERE Id_Film_Genre = @Id_Film_Genre
END
