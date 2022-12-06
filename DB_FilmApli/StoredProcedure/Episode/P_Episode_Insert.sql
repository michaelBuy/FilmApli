CREATE PROCEDURE [dbo].[P_Episode_Insert]
	
	@Numero_Episode INT,
	@Date_Diffusion DATETIME,
	@Titre_Episode NVARCHAR(125),
	@Synopsis_Episode NVARCHAR(500),
	@Id_Saison INT
AS
BEGIN
	INSERT INTO Episode(Id_Saison, Numero_Episode ,Date_Diffusion, Titre_Episode, Synopsis_Episode)
	VALUES (@Id_Saison, @Numero_Episode, @Date_Diffusion, @Titre_Episode, @Synopsis_Episode)
END
