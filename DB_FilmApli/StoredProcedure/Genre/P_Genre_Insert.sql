CREATE PROCEDURE [dbo].[P_Genre_Insert]
	@Nom_Genre NVARCHAR(50)
AS
BEGIN
	INSERT INTO Genre(Nom_Genre)
	VALUES(@Nom_Genre)
END
