CREATE TABLE [HRAppDB].[Employees] (
    [ID]              INT            IDENTITY (1, 1) NOT NULL,
    [Photo]           NVARCHAR (255) NULL,
    [FirstName]       NVARCHAR (255) NOT NULL,
    [LastName]        NVARCHAR (255) NOT NULL,
    [RegistrationDate] NVARCHAR(50)       NOT NULL,
    [StatusID]        INT            NOT NULL,
    [LocationID]      INT            NOT NULL,
    [IsActual]        BIT            NOT NULL,
    CONSTRAINT [PK_EMPLOYEES] PRIMARY KEY CLUSTERED ([ID] ASC),
    CONSTRAINT [Employees_fk0] FOREIGN KEY ([LocationID]) REFERENCES [HRAppDB].[Locations] ([ID]),
    CONSTRAINT [Employees_fk1] FOREIGN KEY ([StatusID]) REFERENCES [HRAppDB].[Statuses] ([ID])
);

