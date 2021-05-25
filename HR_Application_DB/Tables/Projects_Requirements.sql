CREATE TABLE [dbo].[Projects_Requirements] (
    [ID]             INT IDENTITY (1, 1) NOT NULL,
    [ProjectID]      INT NOT NULL,
    [RequirementsID] INT NOT NULL,
    [IsActual]       BIT NOT NULL,
    CONSTRAINT [PK_PROJECTS_REQUIREMENTS] PRIMARY KEY CLUSTERED ([ID] ASC),
    CONSTRAINT [Projects_Requirements_fk0] FOREIGN KEY ([ProjectID]) REFERENCES [dbo].[Projects] ([ID]),
    CONSTRAINT [Projects_Requirements_fk1] FOREIGN KEY ([RequirementsID]) REFERENCES [dbo].[Requirements] ([ID])
);

