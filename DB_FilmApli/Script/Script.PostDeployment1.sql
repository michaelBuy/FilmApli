/* je n 'ai aps 
Modèle de script de post-déploiement							
--------------------------------------------------------------------------------------
 Ce fichier contient des instructions SQL qui seront ajoutées au script de compilation.		
 Utilisez la syntaxe SQLCMD pour inclure un fichier dans le script de post-déploiement.			
 Exemple :      :r .\monfichier.sql								
 Utilisez la syntaxe SQLCMD pour référencer une variable dans le script de post-déploiement.		
 Exemple :      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/

INSERT INTO Film(Titre, DateSortie, Duree, Origine, Synopsis_Film)
VALUES
	('Forrest Gump', '1994-07-06', '2h20', 'USA', 'Quelques décennies d''histoire américaine, des années 1940 à la fin du XXème siècle, à travers le regard et l''étrange odyssée d''un homme simple et pur, Forrest Gump.'),
	('La Liste de Schindler', '1994-02-04', '3h15', 'USA', 'Evocation des années de guerre d''Oskar Schindler, industriel autrichien rentré à Cracovie en 1939 avec les troupes allemandes. Il va, tout au long de la guerre, protéger des juifs en les faisant travailler dans sa fabrique.' ),
	('La Ligne verte', '2000-03-01', '3h09', 'USA', 'Paul Edgecomb, pensionnaire centenaire d''une maison de retraite, est hanté par ses souvenirs. Gardien-chef du pénitencier de Cold Mountain en 1935, il était chargé de veiller au bon déroulement des exécutions capitales en s’efforçant  ' ),
	('Le Parrain', '1972-10-27', '2h55', 'USA', 'En 1945, à New York, les Corleone sont une des cinq familles de la mafia. Don Vito Corleone marie sa fille à un bookmaker. Sollozzo, "parrain" de la famille Tattaglia, propose à Don Vito une association dans le trafic de drogue...' )

INSERT INTO Serie(Nom_Serie, Duree_Serie, DateSortie_Serie, Synopsis_Serie, Origine_Serie)
VALUES
	('Breaking Bad', '47', '2008-01-20', 'Walter White, 50 ans, est professeur de chimie dans un lycée du Nouveau-Mexique. Pour subvenir aux besoins de Skyler, sa femme enceinte, et de Walt Junior, son fils handicapé, il est obligé de travailler doublement. Son quotidien déjà morose devient carrément noir lorsqu''il apprend qu''il est atteint d''un incurable cancer des...', 'USA'),
	('Game of Thrones', '47 a 82', '2011-04-19', 'Il y a très longtemps, à une époque oubliée, une force a détruit l''équilibre des saisons. Dans un pays où l''été peut durer plusieurs années et l''hiver toute une vie, des forces sinistres et surnaturelles se pressent aux portes du Royaume des Sept Couronnes. La confrérie de la Garde de Nuit, protégeant le Royaume de toute', 'USA'),
	('Peaky Blinders', '55', '2013-09-12', 'En 1919, à Birmingham, soldats, révolutionnaires politiques et criminels combattent pour se faire une place dans le paysage industriel de l''après-Guerre. Le Parlement s''attend à une violente révolte, et Winston Churchill mobilise des forces spéciales pour contenir les menaces', 'Grande-Bretagne')

INSERT INTO Personne(Nom, Prenom, DateNaissance, Nationalite)
VALUES
	('Murphy', 'Cillian', '1976-05-25', 'Irlandais'),
	('Turner', 'Sophie', '1996-02-21', 'Britannique'),
	('Cranston', 'Bryan', '1956-03-07', 'Américain'),
	('Spielberg', 'Steven', '1946-12-18', 'Américain'),
	('Morse', 'David', '1953-10-11', 'Américain'),
	('Brando', 'Marlon', '1924-04-03', 'Américain'),
	('Hanks', 'Tom', '1956-07-09', 'Américain')

INSERT INTO Genre(Nom_Genre)
VALUES
	('Comédie'),
	('Action'),
	('Animation'),
	('Drame'),
	('Romance'),
	('Historique'),
	('Guerre'),
	('Policier'),
	('Fantastique')

INSERT INTO Fonction(Nom_Fonction)
VALUES
	('Acteur'),
	('Producteur délégué'),
	('Réalisateur'),	
	('Producteur'),
	('Scénariste')

INSERT INTO Film_Genre(Id_Film, Id_Genre)
VALUES
	(1, 1),
	(1, 5),
	(1, 4),
	(2, 6),
	(2, 7),
	(3, 9),
	(3, 9),
	(4, 8),
	(4, 4)

INSERT INTO Film_Personne(Id_Film, Id_Personne, Id_Fonction)
VALUES
	(3, 5, 1),
	(2, 4, 3),
	(1, 7, 1),
	(4, 6, 1)

INSERT INTO Serie_Genre(Id_Serie, Id_Genre)
VALUES	
	(1, 4 ),
	(2, 4 ),
	(2, 9),
	(3, 4),
	(3, 6),
	(3, 8)


INSERT INTO Serie_Personne(Id_Serie, Id_Personne, Id_Fonction)
VALUES 
	(1, 3, 1),
	(2, 2, 1),
	(3, 1, 1)

INSERT INTO Saison(Id_Serie, Num_Saison, Nom_Saison)
VALUES
	(3, 1, 'Saison 1'),
	(3, 2, 'Saison 2'),
	(3, 3, 'Saison 3'),
	(3, 4, 'Saison 4'),
	(3, 5, 'Saison 5'),
	(3, 6, 'Saison 6'),
	(2, 1, 'Saison 1'),
	(2, 2, 'Saison 2'),
	(2, 3, 'Saison 3'),
	(2, 4, 'Saison 4'),
	(2, 5, 'Saison 5'),
	(2, 6, 'Saison 6'),
	(2, 7, 'Saison 7'),
	(2, 8, 'Saison 8'),
	(1, 1, 'Saison 1'),
	(1, 2, 'Saison 2'),
	(1, 3, 'Saison 3'),
	(1, 4, 'Saison 4'),
	(1, 5, 'Saison 5')
	
INSERT INTO Episode(Id_Saison, Numero_Episode, Date_Diffusion, Titre_Episode, Synopsis_Episode)
VALUES
	(15, 1, '2008-01-20', 'Chute libre', 'Professeur de chimie dans un lycée, Walter White travaille parallèlement dans une station de lavage de voitures afin de boucler les fins de mois de sa famille, composée de sa femme Skyler, qui est enceinte, et de son fils Walter J'),
	(7, 1, '2011-04-17', 'L''hiver vient', 'Au delà d''un gigantesque mur de protection de glace dans le nord de Westeros. Robert Baratheon, le roi, arrive avec son cortège au sud du mur de Winterfell pour demander de l''aide à son vieil ami Eddard Stark.'),
	(1, 1, null, 'Episode 1', 'Birmingham, 1919. Un gang familial règne sur un quartier de la ville : les Peaky Blinders, ainsi nomméspour les lames de rasoir qu’ils cachent dans la visière de leurs casquettes. Paris de bookmakers,marché noir et vols divers sont leur lot quotidien. Mais leur activité prend une dimension...')
