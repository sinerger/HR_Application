CREATE TABLE [dbo].[LevelPositions] (
    [ID]          INT            IDENTITY (1, 1) NOT NULL,
    [Title]       NVARCHAR (255) NOT NULL,
    [Description] NVARCHAR (255) NOT NULL,
    CONSTRAINT [PK_LEVELSPOSITIONS] PRIMARY KEY CLUSTERED ([ID] ASC)
);

