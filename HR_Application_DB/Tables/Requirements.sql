CREATE TABLE [HRAppDB].[Requirements] (
    [ID]                INT IDENTITY (1, 1) NOT NULL,
    [SkillID]           INT NOT NULL,
    [LevelSkillID]      INT NOT NULL,
    [AmountOfEmployees] INT NOT NULL,
    CONSTRAINT [PK_REQUIREMENTS] PRIMARY KEY CLUSTERED ([ID] ASC),
    CONSTRAINT [Requirements_fk0] FOREIGN KEY ([SkillID]) REFERENCES [HRAppDB].[Skills] ([ID]),
    CONSTRAINT [Requirements_fk1] FOREIGN KEY ([LevelSkillID]) REFERENCES [HRAppDB].[LevelSkills] ([ID])
);

