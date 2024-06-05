CREATE TABLE [dbo].[Cars] (
    [CarId]     INT           IDENTITY (1, 1) NOT NULL,
    [Company]   NVARCHAR (50) NOT NULL,
    [AddressCode] INT           NOT NULL,
    [TypeCode]  INT           NOT NULL,
    [lockCode]  INT           NOT NULL,
    [ImageAvailable]     NVARCHAR (50) NOT NULL,
    [ImagePartiallyAvailable]     NVARCHAR (50) NOT NULL,
    [ImageNotAvailable]     NVARCHAR (50) NOT NULL,
    PRIMARY KEY CLUSTERED ([CarId] ASC),
    CONSTRAINT [FK_Cars_TO_Addresses] FOREIGN KEY ([AddressCode]) REFERENCES [dbo].[Addresses] ([Id]),
    CONSTRAINT [FK_Cars_TO_TypeCars] FOREIGN KEY ([TypeCode]) REFERENCES [dbo].[TypeCars] ([Id])
);

CREATE TABLE [dbo].[PayDetails] (
    [Id]       INT           IDENTITY (1, 1) NOT NULL,
    [Number]   NVARCHAR (50) NOT NULL,
    [Validity] NCHAR (10)    NOT NULL,
    [CVV]      NCHAR (10)    NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

CREATE TABLE [dbo].[CarsRental] (
    [Id]       INT           IDENTITY (1, 1) NOT NULL,
    [CarCode]         INT  NOT NULL,
    [UserCode]        INT  NOT NULL,
    [StartTime] DATETIME NOT NULL,
    [EndTime] DATETIME NOT NULL,
    [Returned]    BIT     NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_CarsRental_TO_Users] FOREIGN KEY ([UserCode]) REFERENCES [dbo].[Users] ([UserId]),
    CONSTRAINT [FK_CarsRental_TO_Cars] FOREIGN KEY ([CarCode]) REFERENCES [dbo].[Cars] ([CarId])
);

CREATE TABLE [dbo].[RentalHistory] (
    [Id]       INT           IDENTITY (1, 1) NOT NULL,
    [CarCode]         INT  NOT NULL,
    [UserCode]        INT  NOT NULL,
    [StartTime] DATETIME NOT NULL,
    [EndTime] DATETIME NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_RentalHistory_TO_Users] FOREIGN KEY ([UserCode]) REFERENCES [dbo].[Users] ([UserId]),
    CONSTRAINT [FK_RentalHistory_TO_Cars] FOREIGN KEY ([CarCode]) REFERENCES [dbo].[Cars] ([CarId])
);

