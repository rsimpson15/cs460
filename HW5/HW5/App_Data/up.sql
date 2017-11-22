CREATE TABLE [dbo].[Customers](
	Id int NOT NULL UNIQUE, 
	Dob date NOT NULL, 
	Name varchar(50) NOT NULL, 
	Street varchar(100) NOT NULL, 
	City varchar(20) NOT NULL,
	StateCode varchar(2) NOT NULL, 
	ZipCode int NOT NULL, 
	County varchar(20) NOT NULL, 
	PRIMARY KEY(id)
)

INSERT INTO dbo.Customers(Id, Dob, Name, Street, City, StateCode, ZipCode, County)
VALUES
('934876', '11/04/1980', 'Jassidy Mau', '555 Starlite Way', 'Fremont', 'CA', '90215', 'Milpitas'), 
('9846', '01/17/1978', 'Rainy Dolan', '1492 Columbus Ave', 'Beaverton', 'OR', '98172', 'Portland'),
('201113', '08/24/1958', 'James Nicholas', '15601 S. New Century Dr', 'Palo Alto', 'CA', '90248', 'Los Angeles'),
('2446100', '10/17/1960', 'Hiei Makai', '05729 S. Deerfield St', 'Marigold', 'MA', '13466', 'Westbrook'),
('59687', '12/23/1992', 'Nadia Darakshan', '3521 Spiral Ave', 'Manhattan', 'NY', '25415', 'Manhattan')


