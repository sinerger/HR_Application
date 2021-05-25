CREATE TABLE [dbo].[Employees_Skills] (
    [ID]           INT      IDENTITY (1, 1) NOT NULL,
    [EmployeeID]   INT      NOT NULL,
    [SkillID]      INT      NOT NULL,
    [LevelSkillID] INT      NOT NULL,
    [Date]         DATETIME NOT NULL,
    [IsActual]     BIT      NOT NULL,
    [UserID]       INT      NOT NULL,
    CONSTRAINT [PK_EMPLOYEES_SKILLS] PRIMARY KEY CLUSTERED ([ID] ASC),
    CONSTRAINT [Employees_Skills_fk0] FOREIGN KEY ([EmployeeID]) REFERENCES [dbo].[Employees] ([ID]),
    CONSTRAINT [Employees_Skills_fk1] FOREIGN KEY ([SkillID]) REFERENCES [dbo].[Skills] ([ID]),
    CONSTRAINT [Employees_Skills_fk2] FOREIGN KEY ([LevelSkillID]) REFERENCES [dbo].[LevelSkills] ([ID])
);

