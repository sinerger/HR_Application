CREATE TABLE [dbo].[Users] (
    [ID]        INT            IDENTITY (1, 1) NOT NULL,
    [FisrtName] NVARCHAR (255) NOT NULL,
    [LastName]  NVARCHAR (255) NOT NULL,
    [CompanyID] INT            NOT NULL,
    [Email]     NVARCHAR (255) NOT NULL,
    [Passvord]  NVARCHAR (255) NOT NULL,
    [IsActual]  BIT            NOT NULL,
    CONSTRAINT [PK_USERS] PRIMARY KEY CLUSTERED ([ID] ASC),
    CONSTRAINT [Users_fk0] FOREIGN KEY ([CompanyID]) REFERENCES [dbo].[Companies] ([ID]),
    UNIQUE NONCLUSTERED ([Email] ASC)
);

