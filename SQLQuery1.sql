CREATE TABLE [dbo].[Users] (
    [UserId]          INT           NOT NULL PRIMARY KEY IDENTITY (1, 1),
    [Name]        NVARCHAR (50) NOT NULL,
    [Password]    NVARCHAR (50) NOT NULL,
    [Email]       NVARCHAR (50) NOT NULL,
    [PhoneNumber] INT           NOT NULL,
    [Address]     NVARCHAR (50) NULL
);
CREATE TABLE [dbo].[Cars]
(
	[CarId] INT NOT NULL PRIMARY KEY IDENTITY (1, 1), 
    [BrandAndModel] NVARCHAR(50) NOT NULL, 
    [YearOfManufacture] INT NOT NULL, 
    [LicensePlateNumber] NCHAR(20) NOT NULL, 
    [CarStatus] NVARCHAR(50) NOT NULL
)
CREATE TABLE [dbo].[Reservations]
(
	[ReservationId] INT NOT NULL PRIMARY KEY IDENTITY (1, 1), 
    [UserId] INT NOT NULL, 
    [CarId] INT NOT NULL, 
    [StartDate] DATETIME NOT NULL, 
    [EndDate] DATETIME NOT NULL, 
    [ReservationStatus] NVARCHAR(50) NOT NULL,
    CONSTRAINT FK_Reservation_TO_Users FOREIGN KEY (UserId) REFERENCES Users(UserId),
    CONSTRAINT FK_Reservation_TO_Cars FOREIGN KEY (CarId) REFERENCES Cars(CarId)
)
CREATE TABLE [dbo].[FeedBack]
(
	[FeedBackId] INT NOT NULL PRIMARY KEY IDENTITY (1,1), 
    [UserId] INT NOT NULL, 
    [FeedBackContent] NVARCHAR(MAX) NOT NULL, 
    [Rating] INT NULL,
	CONSTRAINT FK_FeedBack_TO_USER FOREIGN KEY (UserId) REFERENCES Users(UserId)
)
CREATE TABLE [dbo].[Maintenance]
(
	[MaintenanceId] INT NOT NULL PRIMARY KEY identity(1, 1), 
    [CarId] INT NOT NULL, 
    [StartDate] DATETIME NOT NULL, 
    [EndDate] DATETIME NOT NULL, 
    [MaintenanceType] NVARCHAR(50) NOT NULL,
    CONSTRAINT FK_Maintenance_TO_Cars FOREIGN KEY (CarId) REFERENCES Cars(CarId)
)