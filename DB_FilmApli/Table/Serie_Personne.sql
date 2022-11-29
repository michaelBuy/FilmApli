CREATE TABLE [dbo].[Serie_Personne]
(
	[Id_SeriePersonne] INT NOT NULL IDENTITY,
	[Id_Serie] INT NOT NULl,
	[Id_Personne] INT NOT NULL,
	[Id_Fonction] INT NOT NULL ,
	CONSTRAINT FK_Serie_SeriePersonne FOREIGN KEY (Id_Serie)
		REFERENCES Serie(Id_Serie),
	CONSTRAINT FK_Personne_SeriePersonne FOREIGN KEY (Id_Personne)
		REFERENCES Personne(Id_Personne),
	CONSTRAINT FK_Fonction_SeriePersonne FOREIGN KEY (Id_Fonction)
		REFERENCES Fonction(Id_Fonction)
)
