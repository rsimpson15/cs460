/*MARK UP for DATABASE*/

CREATE TABLE [dbo].[Artist] (
    [ArtistID]     INT            NOT NULL,
    [Name]         NVARCHAR (150) NOT NULL,
    [Birthdate]    DATETIME       NOT NULL,
    [BirthCountry] NVARCHAR (150) NOT NULL,
    [BirthCity]    NVARCHAR (100) NOT NULL,
    PRIMARY KEY CLUSTERED ([ArtistID] ASC)
);

CREATE TABLE [dbo].[Artwork] (
    [ArtworkID] INT            NOT NULL,
    [ArtistID]  INT            NOT NULL,
    [Title]     NVARCHAR (100) NOT NULL,
    PRIMARY KEY CLUSTERED ([ArtworkID] ASC),
    FOREIGN KEY ([ArtistID]) REFERENCES [dbo].[Artist] ([ArtistID])
	ON DELETE CASCADE
	ON UPDATE CASCADE
);

CREATE TABLE [dbo].[Genre] (
	[GenreID] INT NOT NULL,
    [Name]    NVARCHAR (50) NOT NULL,
    PRIMARY KEY CLUSTERED ([GenreID] ASC)
);

CREATE TABLE [dbo].[Classification] (
    [ClassificationID] INT NOT NULL,
    [ArtworkID]        INT NOT NULL,
    [GenreID]       INT NOT NULL,
    PRIMARY KEY CLUSTERED ([ClassificationID] ASC),
    FOREIGN KEY ([ArtworkID]) REFERENCES [dbo].[Artwork] ([ArtworkID])
		ON DELETE CASCADE
		ON UPDATE CASCADE,
    FOREIGN KEY ([GenreID]) REFERENCES [dbo].[Genre] ([GenreID])
		ON DELETE CASCADE
		ON UPDATE CASCADE
);

INSERT INTO Artist(ArtistID, Name, Birthdate, BirthCountry, BirthCity)
VALUES
	(1, 'M.C. Esher', 07/17/1898, 'Netherlands', 'Leeuwarden'),
	(2, 'Leonardo Da Vinci', 05/02/1591, 'Italy', 'Vinci'),
	(3, 'Hatip Mehmed Efendi', 11/18/1680, 'Unknown', 'Unknown'),
	(4, 'Salvador Dali', 05/11/1904, 'Spain', 'Figueres');

INSERT INTO Artwork(ArtworkID, ArtistID, Title)
VALUES
	(1, 1, 'Circle Limit III'),
	(2, 1, 'Twon Tree'), 
	(3, 2, 'Mona Lisa'), 
	(4, 2, 'The Vitruvian Man'), 
	(5, 3, 'Ebru'),
	(6, 4, 'Honey Is Sweeter Than Blood');

INSERT INTO Genre(GenreID, Name)
VALUES
	(1, 'Tesselation'), 
	(2, 'Surrealism'), 
	(3, 'Portrait'), 
	(4, 'Renaissance');

INSERT INTO Classification(ClassificationID, ArtworkID, GenreID)
VALUES
	(1, 1, 1), 
	(2, 2, 1),
	(3, 2, 2), 
	(4, 3, 3), 
	(5, 3, 4), 
	(6, 4, 4), 
	(7, 5, 1), 
	(8, 6, 2);
	