CREATE TABLE [HRAppDB].[Departments] (
    [ID]          INT            IDENTITY (1, 1) NOT NULL,
    [Title]       NVARCHAR (255) NULL,
    [Description] NVARCHAR (255) NULL,
    CONSTRAINT [PK_DEPARTMENTS] PRIMARY KEY CLUSTERED ([ID] ASC)
);

