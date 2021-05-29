CREATE TABLE [HRAppDB].[Companies_Depatments] (
    [ID]           INT IDENTITY (1, 1) NOT NULL,
    [CompanyID]    INT NOT NULL,
    [DepartmentID] INT NOT NULL,
    [IsActual]     BIT NOT NULL,
    CONSTRAINT [PK_COMPANIES_DEPATMENTS] PRIMARY KEY CLUSTERED ([ID] ASC),
    CONSTRAINT [Companies_Depatments_fk0] FOREIGN KEY ([CompanyID]) REFERENCES [HRAppDB].[Companies] ([ID]),
    CONSTRAINT [Companies_Depatments_fk1] FOREIGN KEY ([DepartmentID]) REFERENCES [HRAppDB].[Departments] ([ID])
);

