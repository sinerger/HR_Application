CREATE PROCEDURE [HRAppDB].[Employees_ProjectsDirections]
AS
SELECT
ep.ID,
ep.EmployeeID,
ep.StartDate,
ep.EndDate,
ep.IsActual,
pr.ID as IDProjects,
pr.Title as ProjectTitle,
pr.[Description] as ProjectDescription,
di.ID as IDDirections,
di.Title as DirectionsTitle,
di.[Description] as DirectionsDescription

FROM [HRAppDB].[Employees_Projects] as ep

INNER JOIN [HRAppDB].[Projects] as pr
ON
ep.ProjectID=pr.ID

INNER JOIN [HRAppDB].[Directions] as di
ON
pr.DirectionID=di.ID
