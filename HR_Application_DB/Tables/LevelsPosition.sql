CREATE TABLE [HRAppDB].[LevelsPosition] (
    [ID]          INT            IDENTITY (1, 1) NOT NULL,
    [Title]       NVARCHAR (255) NOT NULL,
    [Description] NVARCHAR (255) NOT NULL,
    CONSTRAINT [PK_LEVELSPOSITION] PRIMARY KEY CLUSTERED ([ID] ASC)
);

