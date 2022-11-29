CREATE TABLE [dbo].[Saison]
(
	[Id_Saison] INT NOT NULL PRIMARY KEY IDENTITY(1, 1),
	[Id_Serie] INT NOT NULL,
	[Num_Saison] INT,
	[Nom_Saison] NVARCHAR(50),
	CONSTRAINT FK_Id_Serie_Saison FOREIGN KEY (Id_Serie)
		REFERENCES Serie(Id_Serie)

)
