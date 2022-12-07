CREATE PROCEDURE [dbo].[P_Saison_Insert]
	@Id_Serie INT,
	@Num_Saison INT,
	@Nom_Saison NVARCHAR(50)
AS
BEGIN
	INSERT INTO Saison(Id_Serie, Num_Saison, Nom_Saison)
	VALUES(@Id_Serie, @Num_Saison, @Nom_Saison)
END
