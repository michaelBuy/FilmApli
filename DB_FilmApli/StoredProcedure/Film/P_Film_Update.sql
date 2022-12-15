﻿CREATE PROCEDURE [dbo].[P_Film_Update]
	@Id_Film INT,
	@Titre NVARCHAR(50),
	@DateSortie DATETIME2,
	@Duree NVARCHAR(25),
	@Origine NVARCHAR(50),
	@Synopsis NVARCHAR(500),
	@Img_Url NVARCHAR(100)
AS
BEGIN
	UPDATE Film
	SET Titre = @Titre, DateSortie = @DateSortie, Duree = @Duree, 
		Origine = @Origine, Synopsis_Film = @Synopsis, @Img_Url = Img_Url
	WHERE Id_Film = @Id_Film
END
