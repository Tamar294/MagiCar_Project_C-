CREATE TABLE [dbo].[CarsToUsers] (
    [Id]     INT IDENTITY (1, 1) NOT NULL,
    [UserId] INT NOT NULL,
    [CarId]  INT NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_CarsToUsers_TO_Users] FOREIGN KEY ([UserId]) REFERENCES [dbo].[Users] ([UserId]),
    CONSTRAINT [FK_CarsToUsers_TO_Cars] FOREIGN KEY ([CarId]) REFERENCES [dbo].[Cars] ([CarId])


);