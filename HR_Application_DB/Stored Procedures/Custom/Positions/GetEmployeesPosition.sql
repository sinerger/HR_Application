CREATE PROCEDURE [HRAppDB].[GetEmployeesPosition]
AS
SELECT
pe.ID,
pe.EmployeeID,
pe.HiredDate,
pe.FiredDate,
pe.IsActual,
lp.ID,
lp.Title,
lp.[Description],
p.ID,
p.Title,
p.[Description]

FROM [HRAppDB].[Positions_Employees] as pe
INNER JOIN [HRAppDB].[LevelsPosition] as lp
ON
pe.LevelsPosition=lp.ID

INNER JOIN [HRAppDB].[Positions] as p
ON
pe.PositionID=p.ID