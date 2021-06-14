CREATE TABLE [HRAppDB].[Departments_Projects] (
    [ID]           INT IDENTITY (1, 1) NOT NULL,
    [ProjectID]    INT NOT NULL,
    [DepartmentID] INT NOT NULL,
    [IsActual]     BIT NULL,
    CONSTRAINT [PK_DEPARTMENTS_PROJECTS] PRIMARY KEY CLUSTERED ([ID] ASC),
    CONSTRAINT [Departments_Projects_fk0] FOREIGN KEY ([ProjectID]) REFERENCES [HRAppDB].[Projects] ([ID]),
    CONSTRAINT [Departments_Projects_fk1] FOREIGN KEY ([DepartmentID]) REFERENCES [HRAppDB].[Departments] ([ID])
);

