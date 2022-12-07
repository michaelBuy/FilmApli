CREATE PROCEDURE [dbo].[P_SerieGenre_Insert]
	@Id_Serie INT,
	@Id_Genre INT,
	@PEGI_Serie_Genre INT
AS
BEGIN
	INSERT INTO Serie_Genre(Id_Serie, Id_Genre, PEGI_Serie_Genre)
	VALUES (@Id_Serie, @Id_Genre, @PEGI_Serie_Genre)
END
