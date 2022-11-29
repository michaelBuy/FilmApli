CREATE TABLE [dbo].[Personne]
(
	[Id_Personne] INT NOT NULL PRIMARY KEY IDENTITY,
	[Nom] NVARCHAR(50) NOT NULL,
	[Prenom] NVARCHAR(50) NOT NULL,
	[DateNaissance] DATETIME2, 
	[Nationalite] NVARCHAR(50)
)
