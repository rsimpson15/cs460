CREATE TABLE [dbo].[Customers](
	id int NOT NULL UNIQUE, 
	dob date NOT NULL, 
	name varchar(50) NOT NULL, 
	street varchar(100) NOT NULL, 
	city varchar(20) NOT NULL,
	stateCode varchar(2) NOT NULL, 
	zipCode int NOT NULL, 
	county varchar(20) NOT NULL, 
	PRIMARY KEY(id)
)

INSERT INTO dbo.Customers(id, dob, name, street, city, stateCode, zipCode, county)
VALUES('934876', '11/04/1980', 'Jassidy Mau', '555 Starlite Way', 'Fremont', 'CA', '90215', 'Milpitas')

INSERT INTO dbo.Customers(id, dob, name, street, city, stateCode, zipCode, county)
VALUES('9846', '01/17/1978', 'Rainy Dolan', '1492 Columbus Ave', 'Beaverton', 'OR', '98172', 'Portland')

INSERT INTO dbo.Customers(id, dob, name, street, city, stateCode, zipCode, county)
VALUES('201113', '08/24/1958', 'James Nicholas', '15601 S. New Century Dr', 'Palo Alto', 'CA', '90248', 'Los Angeles')

INSERT INTO dbo.Customers(id, dob, name, street, city, stateCode, zipCode, county)
VALUES('2446100', '10/17/1960', 'Hiei Makai', '05729 S. Deerfield St', 'Marigold', 'MA', '13466', 'Westbrook')

INSERT INTO dbo.Customers(id, dob, name, street, city, stateCode, zipCode, county)
VALUES('59687', '12/23/1992', 'Nadia Darakshan', '3521 Spiral Ave', 'Manhattan', 'NY', '25415', 'Manhattan')

SELECT * FROM [dbo].[Customers]

