CREATE PROCEDURE [dbo].[P_Personne_Insert]
	@Nom NVARCHAR(50),
	@Prenom NVARCHAR(50),
	@DateNaissance DATETIME2,
	@Nationalite NVARCHAR(50)
AS
BEGIN
	INSERT INTO Personne(Nom, Prenom, DateNaissance, Nationalite)
	VALUES(@Nom, @Prenom, @DateNaissance, @Nationalite)
END
