CREATE PROCEDURE [dbo].[P_Film_Insert]
	@Id int,
	@Titre NVARCHAR(50),
	@DateSortie DATETIME2,
	@Duree NVARCHAR(25),
	@Origine NVARCHAR(50),
	@Synopsis NVARCHAR(500)
	
AS
BEGIN
	INSERT INTO Film(Titre, DateSortie, Duree, Origine, Synopsis_Film)
	VALUES(@Titre, @DateSortie, @Duree, @Origine, @Synopsis)

	declare @IdFilm int = scope_identity()

	insert into dbo.imgApi (Id_Film, Id_Beta) values (@IdFilm, @Id)
END
