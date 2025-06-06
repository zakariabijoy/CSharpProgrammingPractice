﻿CREATE TABLE [dbo].[Address]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [PersonId] INT NOT NULL, 
    [City] NVARCHAR(50) NULL, 
    [StreeAddress] NVARCHAR(50) NULL, 
    [ZipCode] NVARCHAR(50) NULL, 
    CONSTRAINT [FK_Address_Person] FOREIGN KEY ([PersonId]) REFERENCES [Person](PersonId)
)
