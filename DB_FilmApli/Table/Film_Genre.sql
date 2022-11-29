CREATE TABLE [dbo].[Film_Genre]
(
	[Id_Film_Genre] INT NOT NULL PRIMARY KEY IDENTITY,
	[Id_Film] INT NOT NULL,
	[Id_Genre] INT NOT NULL,
	[LIFO_Film_Genre] INT,
	CONSTRAINT FK_Genre_FilmGenre FOREIGN KEY (Id_Genre)
		REFERENCES Genre(Id_Genre),
	CONSTRAINT FK_Film_FilmGenre FOREIGN KEY (Id_Film)
		REFERENCES Film(Id_Film)
)
