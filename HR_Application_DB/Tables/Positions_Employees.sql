CREATE TABLE [HRAppDB].[Positions_Employees] (
    [ID]            INT            IDENTITY (1, 1) NOT NULL,
    [EmployeeID]    INT            NOT NULL,
    [PositionID]    INT            NOT NULL,
    [HiredDate]     NVARCHAR (255) NOT NULL,
    [FiredDate]     NVARCHAR (255) NOT NULL,
    [IsActual]      BIT            NOT NULL,
    [LevelPosition] INT            NOT NULL,
    CONSTRAINT [PK_POSITIONS_EMPLOYEES] PRIMARY KEY CLUSTERED ([ID] ASC),
    CONSTRAINT [Positions_Employees_fk0] FOREIGN KEY ([EmployeeID]) REFERENCES [HRAppDB].[Employees] ([ID]),
    CONSTRAINT [Positions_Employees_fk1] FOREIGN KEY ([PositionID]) REFERENCES [HRAppDB].[Positions] ([ID]),
    CONSTRAINT [Positions_Employees_fk2] FOREIGN KEY ([LevelPosition]) REFERENCES [HRAppDB].[LevelPositions] ([ID])
);

