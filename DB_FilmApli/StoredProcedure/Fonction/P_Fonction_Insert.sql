CREATE PROCEDURE [dbo].[P_Fonction_Insert]
	@Nom_Fonction NVARCHAR(125)
AS
BEGIN
	INSERT INTO Fonction(Nom_Fonction)
	VALUES(@Nom_Fonction)
END
