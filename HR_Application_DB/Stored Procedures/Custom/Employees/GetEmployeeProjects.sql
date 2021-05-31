CREATE PROCEDURE [HRAppDB].[GetEmployeeProjects]
AS
SELECT
ep.ID as IDEmployeeProject,
ep.StartDate,
ep.EndDate,
ep.EmployeeID,
pr.ID as ProjectID


FROM [HRAppDB].[Employees_Projects] as ep

INNER JOIN [HRAppDB].[Projects] as pr
ON
ep.ProjectID=pr.ID

INNER JOIN [HRAppDB].[Directions] as di
ON
pr.DirectionID=di.ID
JOIN [HRAppDB].[Employees] as Employees
on
ep.EmployeeID = Employees.ID
