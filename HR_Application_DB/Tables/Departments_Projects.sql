CREATE TABLE [dbo].[Departments_Projects] (
    [ID]           INT IDENTITY (1, 1) NOT NULL,
    [ProjectID]    INT NOT NULL,
    [DepartmentID] INT NOT NULL,
    [IsActual]     BIT NOT NULL,
    CONSTRAINT [PK_DEPARTMENTS_PROJECTS] PRIMARY KEY CLUSTERED ([ID] ASC),
    CONSTRAINT [Departments_Projects_fk0] FOREIGN KEY ([ProjectID]) REFERENCES [dbo].[Projects] ([ID]),
    CONSTRAINT [Departments_Projects_fk1] FOREIGN KEY ([DepartmentID]) REFERENCES [dbo].[Departments] ([ID])
);

