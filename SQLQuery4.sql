

CREATE TABLE [dbo].[Cars] (
    [CarId]     INT           IDENTITY (1, 1) NOT NULL,
    [Company]   NVARCHAR (50) NOT NULL,
    [AddressId] INT           NOT NULL,
    [TypeCode]  INT           NOT NULL,
    [lockCode]  INT           NOT NULL,
    [Image] NVARCHAR(50) NOT NULL, 
    PRIMARY KEY CLUSTERED ([CarId] ASC),
    CONSTRAINT [FK_Cars_TO_Addresses] FOREIGN KEY ([AddressId]) REFERENCES [dbo].[Addresses] ([Id]),
    CONSTRAINT [FK_Cars_TO_TypeCars] FOREIGN KEY ([TypeCode]) REFERENCES [dbo].[TypeCars] ([Id])
       
);

