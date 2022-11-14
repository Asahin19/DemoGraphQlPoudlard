CREATE TABLE [dbo].[Awards]
(
	[Id] INT NOT NULL PRIMARY KEY,
    [Point] INT NULL,
    [HouseId] INT NULL,
    [ProfessorId] INT NULL,

    CONSTRAINT [FK_Award_House] FOREIGN KEY ([HouseId]) REFERENCES [dbo].[Houses] ([Id]),
    CONSTRAINT [FK_Award_Professor] FOREIGN KEY ([ProfessorId]) REFERENCES [dbo].[Professors] ([Id])
)
