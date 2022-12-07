CREATE PROCEDURE [dbo].[P_Saison_Update]
	@Id_Saison INT,
	@Id_Serie INT,
	@Num_Saison INT,
	@Nom_Saison NVARCHAR(50)
AS
BEGIN 
	UPDATE Saison
	SET Id_Serie = Id_Serie, Num_Saison = @Num_Saison, Nom_Saison = @Nom_Saison
	WHERE Id_Saison = @Id_Saison
END 
