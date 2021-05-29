CREATE TABLE [HRAppDB].[Projects] (
    [ID]          INT            IDENTITY (1, 1) NOT NULL,
    [Title]       NVARCHAR (255) NOT NULL,
    [Description] NVARCHAR (255) NOT NULL,
    [DirectionID] INT            NOT NULL,
    CONSTRAINT [PK_PROJECTS] PRIMARY KEY CLUSTERED ([ID] ASC),
    CONSTRAINT [Projects_fk0] FOREIGN KEY ([DirectionID]) REFERENCES [HRAppDB].[Directions] ([ID])
);

