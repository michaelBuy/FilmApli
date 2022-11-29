CREATE PROCEDURE [dbo].[P_Personne_Update]
	@Id_Personne INT,
	@Nom NVARCHAR(50),
	@Prenom NVARCHAR(50),
	@DateNaissance DATETIME2,
	@Nationalite NVARCHAR(50)
AS
BEGIN
	UPDATE Personne
	SET Nom = @Nom, Prenom = @Prenom, DateNaissance = @DateNaissance, Nationalite = @Nationalite
	WHERE Id_Personne = @Id_Personne
END
