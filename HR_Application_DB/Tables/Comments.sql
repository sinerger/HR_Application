CREATE TABLE [HRAppDB].[Comments] (
    [ID]          INT            IDENTITY (1, 1) NOT NULL,
    [EmployeeID]  INT            NOT NULL,
    [Information] NVARCHAR (255) NOT NULL,
    [Date]        DATETIME       NOT NULL,
    CONSTRAINT [PK_COMMENTS] PRIMARY KEY CLUSTERED ([ID] ASC),
    CONSTRAINT [Comments_fk0] FOREIGN KEY ([EmployeeID]) REFERENCES [HRAppDB].[Employees] ([ID])
);

