CREATE TABLE [dbo].[Searches] (
    [ID]         INT            IDENTITY (1, 1) NOT NULL,
    [SearchTerm] NVARCHAR (150) NOT NULL,
    [SearchDate] DATETIME       NOT NULL,
    [IPAddress]  NVARCHAR(150)            NOT NULL,
    [Browser]    NVARCHAR (250) NOT NULL,
    PRIMARY KEY CLUSTERED ([ID] ASC)
);