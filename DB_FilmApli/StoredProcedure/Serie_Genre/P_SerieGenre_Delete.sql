CREATE PROCEDURE [dbo].[P_SerieGenre_Delete]
	@Id_Serie_Genre INT
AS
BEGIN
	DELETE FROM Serie_Genre
	WHERE Id_Serie_Genre = @Id_Serie_Genre
END
