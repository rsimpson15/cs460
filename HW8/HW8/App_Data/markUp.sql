/*MARK UP for DATABASE*/

INSERT INTO Artist(ArtistID, Name, Birthdate, BirthCountry, BirthCity)
VALUES
	(00, 'M.C. Esher', 07/17/1898, 'Netherlands', 'Leeuwarden'),
	(01, 'Leonardo Da Vinci', 05/02/1591, 'Italy', 'Vinci'),
	(02, 'Hatip Mehmed Efendi', 11/18/1680, 'Unknown', 'Unknown'),
	(03, 'Salvador Dali', 05/11/1904, 'Spain', 'Figueres');

INSERT INTO Artwork(ArtworkID, ArtistID, Title)
VALUES
	(00, 00, 'Circle Limit III'),
	(01, 00, 'Twon Tree'), 
	(02, 01, 'Mona Lisa'), 
	(03, 01, 'The Vitruvian Man'), 
	(04, 02, 'Ebru'),
	(05,03, 'Honey Is Sweeter Than Blood');

INSERT INTO Genre(GenreID, Name)
VALUES
	(00, 'Tesselation'), 
	(01, 'Surrealism'), 
	(02, 'Portrait'), 
	(03, 'Renaissance');

INSERT INTO Classification(ClassID, ArtworkID, GenreID)
VALUES
	(00, 00, 00), 
	(01, 01, 00),
	(02, 01, 01), 
	(03, 02, 02), 
	(04, 02, 03), 
	(05, 03, 03), 
	(06, 04, 00), 
	(07, 05, 01);
	