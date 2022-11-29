CREATE TABLE [dbo].[Film_Personne]
(
	[Id_FIlm_Personne] INT NOT NULL PRIMARY KEY IDENTITY,
	[Id_Film] INT NOT NULL,
	[Id_Personne] INT NOT NULL,
	[Id_Fonction] INT NOT NULL,
	CONSTRAINT FK_Film_FilmPersonne FOREIGN KEY (Id_Film)
		REFERENCES Film(Id_Film),
	CONSTRAINT FK_Personne_FilmPersonne FOREIGN KEY (Id_Personne)
		REFERENCES Personne(Id_Personne),
	CONSTRAINT FK_Fonction_FilmPersonne FOREIGN KEY (Id_Fonction)
		REFERENCES Fonction(Id_Fonction)
)
