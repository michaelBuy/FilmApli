CREATE PROCEDURE [dbo].[P_FilmGenre_Insert]
	@PEGI_Film_Genre INT,
	@Id_Film INT,
	@Id_Genre INT
AS
BEGIN
	INSERT INTO Film_Genre(PEGI_Film_Genre, Id_Film, Id_Genre)
	VALUES (@PEGI_Film_Genre, @Id_Film, @Id_Genre)
END
