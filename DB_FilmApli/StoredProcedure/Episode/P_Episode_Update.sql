CREATE PROCEDURE [dbo].[P_Episode_Update]
	@Id_Episode INT,
	@Numero_Episode INT,
	@Date_Diffusion DATETIME,
	@Titre_Episode NVARCHAR(125),
	@Synopsis_Episode NVARCHAR(500),
	@Id_Saison INT
AS
BEGIN
	UPDATE Episode
	SET Numero_Episode = @Numero_Episode, Date_Diffusion = @Date_Diffusion, 
		Titre_Episode= @Titre_Episode, Synopsis_Episode = @Synopsis_Episode
	WHERE Id_Episode = @Id_Episode
END
