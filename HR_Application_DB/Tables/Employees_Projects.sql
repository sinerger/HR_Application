CREATE TABLE [HRAppDB].[Employees_Projects] (
    [ID]         INT            IDENTITY (1, 1) NOT NULL,
    [EmployeeID] INT            NOT NULL,
    [ProjectID]  INT            NOT NULL,
    [StartDate]  NVARCHAR (255) NULL,
    [EndDate]    NVARCHAR (255) NULL,
    [IsActual]   BIT            NOT NULL,
    CONSTRAINT [PK_EMPLOYEES_PROJECTS] PRIMARY KEY CLUSTERED ([ID] ASC),
    CONSTRAINT [Employees_Projects_fk0] FOREIGN KEY ([EmployeeID]) REFERENCES [HRAppDB].[Employees] ([ID]),
    CONSTRAINT [Employees_Projects_fk1] FOREIGN KEY ([ProjectID]) REFERENCES [HRAppDB].[Projects] ([ID])
);

