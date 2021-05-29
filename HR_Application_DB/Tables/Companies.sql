CREATE TABLE [HRAppDB].[Companies] (
    [ID]          INT            IDENTITY (1, 1) NOT NULL,
    [Title]       NVARCHAR (255) NOT NULL,
    [LocationID]  INT            NOT NULL,
    [Description] NVARCHAR (255) NOT NULL,
    [IsActual]    BIT            NOT NULL,
    CONSTRAINT [PK_COMPANIES] PRIMARY KEY CLUSTERED ([ID] ASC)
);

