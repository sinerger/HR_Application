CREATE TABLE [HRAppDB].[GeneralInformation] (
    [ID]             INT            IDENTITY (1, 1) NOT NULL,
    [EmployeeID]     INT            NOT NULL,
    [Sex]            NVARCHAR (255) NOT NULL,
    [Education]      NVARCHAR (255) NULL,
    [FamilyStatusID] INT            NOT NULL,
    [Phone]          NVARCHAR (15)  NOT NULL,
    [Email]          NVARCHAR (255) NOT NULL,
    [BirthDate]      DATETIME       NOT NULL,
    [Hobby]          NVARCHAR (255) NULL,
    [AmountChildren] INT            NULL,
    CONSTRAINT [PK_GENERALINFORMATION] PRIMARY KEY CLUSTERED ([ID] ASC),
    CONSTRAINT [GeneralInformation_fk0] FOREIGN KEY ([EmployeeID]) REFERENCES [HRAppDB].[Employees] ([ID]),
    CONSTRAINT [GeneralInformation_fk1] FOREIGN KEY ([FamilyStatusID]) REFERENCES [HRAppDB].[FamilyStatuses] ([ID]),
    UNIQUE NONCLUSTERED ([Email] ASC),
    UNIQUE NONCLUSTERED ([Phone] ASC)
);

