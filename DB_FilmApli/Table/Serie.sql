CREATE TABLE [dbo].[Serie]
(
	[Id_Serie] INT NOT NULL PRIMARY KEY IDENTITY,
	[Nom_Serie] NVARCHAR(125) NOT NULL,
	[Duree_Serie] NVARCHAR(25), 
	[DateSortie_Serie] DATETIME2,
	[Synopsis_Serie] NVARCHAR(500),
	[Origine_Serie] NVARCHAR(50)
)
