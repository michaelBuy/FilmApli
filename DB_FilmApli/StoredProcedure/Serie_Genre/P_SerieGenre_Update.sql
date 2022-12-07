CREATE PROCEDURE [dbo].[P_SerieGenre_Update]
	@Id_Serie_Genre INT,
	@Id_Serie INT,
	@Id_Genre INT,
	@PEGI_Serie_Genre INT
AS
BEGIN
	UPDATE Serie_Genre
	SET Id_Serie = @Id_Serie, Id_Genre = @Id_Genre, PEGI_Serie_Genre = @PEGI_Serie_Genre
	WHERE Id_Serie_Genre = @Id_Serie_Genre
END
