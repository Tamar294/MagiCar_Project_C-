CREATE TABLE [dbo].[Cars] (
    [CarId]     INT           IDENTITY (1, 1) NOT NULL,
    [Company]   NVARCHAR (50) NOT NULL,
    [AddressId] INT           NOT NULL,
    [TypeCode]  INT           NOT NULL,
    [lockCode]  INT           NOT NULL,
    PRIMARY KEY CLUSTERED ([CarId] ASC),
    CONSTRAINT FK_Cars_TO_Addresses FOREIGN KEY (AddressId) REFERENCES Addresses(Id),
    CONSTRAINT FK_Cars_TO_TypeCars FOREIGN KEY (TypeCode) REFERENCES TypeCars(Id),

);
CREATE TABLE [dbo].[CarsToUsers] (
    [Id]     INT IDENTITY (1, 1) NOT NULL,
    [UserId] INT NOT NULL,
    [CarId]  INT NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT FK_CarsToUsers_TO_Cars FOREIGN KEY (CarId) REFERENCES Cars(CarId),
    CONSTRAINT FK_CarsToUsers_TO_Users FOREIGN KEY (UserId) REFERENCES Users(UserId)
);

