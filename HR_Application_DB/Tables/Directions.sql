CREATE TABLE [dbo].[Directions] (
    [ID]          INT            IDENTITY (1, 1) NOT NULL,
    [Title]       NVARCHAR (255) NOT NULL,
    [Description] NVARCHAR (255) NOT NULL,
    CONSTRAINT [PK_DIRECTIONS] PRIMARY KEY CLUSTERED ([ID] ASC)
);

