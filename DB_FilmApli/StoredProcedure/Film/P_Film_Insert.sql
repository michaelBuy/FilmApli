CREATE PROCEDURE [dbo].[P_Film_Insert]
	@Titre NVARCHAR(50),
	@DateSortie DATETIME2,
	@Duree NVARCHAR(25),
	@Origine NVARCHAR(50),
	@Synopsis NVARCHAR(500)
AS
BEGIN
	INSERT INTO Film(Titre, DateSortie, Duree, Origine, Synopsis_Film)
	VALUES(@Titre, @DateSortie, @Duree, @Origine, @Synopsis)
END
