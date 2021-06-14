CREATE TABLE [HRAppDB].[Companies] (
    [ID]          INT            IDENTITY (1, 1) NOT NULL,
    [Title]       NVARCHAR (255) NULL,
    [LocationID]  INT            NULL,
    [Description] NVARCHAR (255) NULL,
    [IsActual]    BIT            NULL,
    CONSTRAINT [PK_COMPANIES] PRIMARY KEY CLUSTERED ([ID] ASC)
);

