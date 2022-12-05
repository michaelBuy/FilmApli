CREATE PROCEDURE [dbo].[P_Serie_Insert]	
	@Nom_Serie NVARCHAR(125),
	@Duree_Serie NVARCHAR(25),
	@DateSortie_Serie DATETIME2, 
	@Synopsis_Serie NVARCHAR(500),
	@Origine_Serie NVARCHAR(50)
AS
BEGIN 
	INSERT INTO Serie(Nom_Serie, Duree_Serie, DateSortie_Serie, Synopsis_Serie, Origine_Serie)
	VALUES (@Nom_Serie, @Duree_Serie, @DateSortie_Serie, @Synopsis_Serie, @Origine_Serie)
END
