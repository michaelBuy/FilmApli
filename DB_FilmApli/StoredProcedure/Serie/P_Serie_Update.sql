CREATE PROCEDURE [dbo].[P_Serie_Update]
	@Id_Serie INT,
	@Nom_Serie NVARCHAR(125),
	@Duree_Serie NVARCHAR(25),
	@DateSortie_Serie DATETIME2, 
	@Synopsis_Serie NVARCHAR(500),
	@Origine_Serie NVARCHAR(50)
AS
BEGIN 
	UPDATE Serie
	SET Nom_Serie = @Nom_Serie, Duree_Serie = @Duree_Serie, 
		DateSortie_Serie = @DateSortie_Serie, Synopsis_Serie = @Synopsis_Serie,
		Origine_Serie =  @Origine_Serie
	WHERE Id_Serie = @Id_Serie
END
