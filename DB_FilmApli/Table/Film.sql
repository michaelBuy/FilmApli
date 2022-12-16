CREATE TABLE [dbo].[Film]
(
	[Id_Film] INT NOT NULL PRIMARY KEY IDENTITY,
	[Titre] NVARCHAR(50) NOT NULL,
	[DateSortie] DATETIME2,
	[Duree] NVARCHAR(25),
	[Origine] NVARCHAR(50),
	[Synopsis_Film] NVARCHAR(500),
	[Img_Url] NVARCHAR(100)
)
