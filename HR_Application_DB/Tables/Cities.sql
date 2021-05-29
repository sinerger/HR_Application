CREATE TABLE [HRAppDB].[Cities] (
    [ID]        INT            IDENTITY (1, 1) NOT NULL,
    [Name]      NVARCHAR (255) NOT NULL,
    [CountryID] INT            NOT NULL,
    CONSTRAINT [PK_CITIES] PRIMARY KEY CLUSTERED ([ID] ASC),
    CONSTRAINT [Cities_fk0] FOREIGN KEY ([CountryID]) REFERENCES [HRAppDB].[Countries] ([ID])
);

