CREATE TABLE [dbo].[Product]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [CategoryId] VARCHAR(50) NOT NULL, 
    [BrandId] VARCHAR(50) NOT NULL, 
    [Quantity] DECIMAL(18, 2) NOT NULL, 
    [Price] DECIMAL(18, 2) NOT NULL
)
