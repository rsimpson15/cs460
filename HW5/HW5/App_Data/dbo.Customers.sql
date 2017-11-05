CREATE TABLE [dbo].[Customers] (
    [ID]        INT           NOT NULL,
    [DOB]       DATE          NOT NULL,
    [NAME]      VARCHAR (50)  NOT NULL,
    [STREET]    VARCHAR (100) NOT NULL,
    [CITY]      VARCHAR (20)  NOT NULL,
    [STATECODE] VARCHAR (2)   NOT NULL,
    [ZIPCODE]   INT           NOT NULL,
    [COUNTY]    VARCHAR (20)  NOT NULL,
    PRIMARY KEY CLUSTERED ([ID] ASC),
    UNIQUE NONCLUSTERED ([ID] ASC)
);

