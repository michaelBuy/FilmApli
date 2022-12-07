CREATE TABLE [dbo].[Serie_Genre]
(
	[Id_Serie_Genre] INT NOT NULL PRIMARY KEY IDENTITY,
	[Id_Serie] INT NOT NULL,
	[Id_Genre] INT NOT NULL,
	[PEGI_Serie_Genre] INT,
	CONSTRAINT FK_Serie_SerieGenre FOREIGN KEY (Id_Serie)
		REFERENCES Serie(Id_Serie),
	CONSTRAINT FK_Genre_SerieGenre FOREIGN KEY (Id_Genre)
		REFERENCES Genre(Id_Genre),
)
