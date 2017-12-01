/*MARK UP for DATABASE*/

USE [C:\USERS\ROCHELLE SIMPSON\DOCUMENTS\CS460\HW8\HW8\APP_DATA\ARTGALLERYDB.MDF];  

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
    [GenreID]        NVARCHAR (50) NOT NULL,
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

INSERT INTO Classification(ClassificationID, ArtworkID, GenreID)
VALUES
	(00, 00, 00), 
	(01, 01, 00),
	(02, 01, 01), 
	(03, 02, 02), 
	(04, 02, 03), 
	(05, 03, 03), 
	(06, 04, 00), 
	(07, 05, 01);
	