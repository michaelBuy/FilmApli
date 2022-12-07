CREATE PROCEDURE [dbo].[P_Fonction_Update]
	@Id_Fonction INT,
	@Nom_Fonction NVARCHAR(125)
AS
BEGIN
	UPDATE Fonction
	SET Nom_Fonction = @Nom_Fonction
	WHERE Id_Fonction = @Id_Fonction
END