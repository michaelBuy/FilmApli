CREATE PROCEDURE [dbo].[P_Genre_Update]
	@Nom_Genre NVARCHAR(50),
	@Id_Genre INT
AS
BEGIN
	UPDATE Genre
	SET Nom_Genre = @Nom_Genre
	WHERE Id_Genre = @Id_Genre
END
