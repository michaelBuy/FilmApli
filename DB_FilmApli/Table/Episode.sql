CREATE TABLE [dbo].[Episode]
(
	[Id_Episode] INT NOT NULL PRIMARY KEY IDENTITY,
	[Id_Saison] INT NOT NULL,
	[Numero_Episode] INT, 
	[Date_Diffusion] DATETIME2,
	[Titre_Episode] NVARCHAR(125),
	[Synopsis_Episode] NVARCHAR(500),
	CONSTRAINT FK_Id_Saison_Episode FOREIGN KEY (Id_Saison)
		REFERENCES Saison(Id_Saison)
)
