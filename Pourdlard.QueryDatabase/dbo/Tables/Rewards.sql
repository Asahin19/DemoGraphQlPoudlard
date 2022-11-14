CREATE TABLE [dbo].[Rewards]
(
	[Id] INT NOT NULL PRIMARY KEY,
    [Point] INT NULL,
    [HouseId] INT NOT NULL,
    [ProfessorId] INT NOT NULL,
    [Description] VARCHAR(500) NULL,

    CONSTRAINT [FK_Reward_House] FOREIGN KEY ([HouseId]) REFERENCES [dbo].[Houses] ([Id]),
    CONSTRAINT [FK_Reward_Professor] FOREIGN KEY ([ProfessorId]) REFERENCES [dbo].[Professors] ([Id])
)
