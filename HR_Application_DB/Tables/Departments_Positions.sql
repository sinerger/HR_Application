CREATE TABLE [dbo].[Departments_Positions] (
    [ID]           INT IDENTITY (1, 1) NOT NULL,
    [DepartmentID] INT NOT NULL,
    [PositionID]   INT NOT NULL,
    [IsActual]     BIT NOT NULL,
    CONSTRAINT [PK_DEPARTMENTS_POSITIONS] PRIMARY KEY CLUSTERED ([ID] ASC),
    CONSTRAINT [Departments_Positions_fk0] FOREIGN KEY ([DepartmentID]) REFERENCES [dbo].[Departments] ([ID]),
    CONSTRAINT [Departments_Positions_fk1] FOREIGN KEY ([PositionID]) REFERENCES [dbo].[Positions] ([ID])
);

