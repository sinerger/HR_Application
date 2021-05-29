CREATE PROCEDURE [HRAppDB].[Positions_EmployeesPositionsLevelPositions]
AS
SELECT
pe.ID,
pe.EmployeeID,
pe.HiredDate,
pe.FiredDate,
pe.IsActual,
lp.ID as IDLevelsPositions,
lp.Title as TitleLevelsPositions,
lp.[Description],
p.ID as IDPositions,
p.Title as TitlePositions,
p.[Description]

FROM [HRAppDB].[Positions_Employees] as pe
INNER JOIN [HRAppDB].[LevelsPositions] as lp
ON
pe.LevelPosition=lp.ID

INNER JOIN [HRAppDB].[Positions] as p
ON
pe.PositionID=p.ID