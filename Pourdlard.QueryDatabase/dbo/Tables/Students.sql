CREATE TABLE [dbo].[Students]
(
	[Id] INT NOT NULL IDENTITY(1, 1) PRIMARY KEY, 
    [LastName] VARCHAR(50) NULL, 
    [FirstName] VARCHAR(50) NULL,
    [BirthDate] DATETIME2 NULL,
    [HouseId] INT NULL,

    CONSTRAINT [FK_Student_House] FOREIGN KEY ([HouseId]) REFERENCES [dbo].[Houses] ([Id])
)
