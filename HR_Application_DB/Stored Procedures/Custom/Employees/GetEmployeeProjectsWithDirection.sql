CREATE PROCEDURE [HRAppDB].[GetEmployeeProjects]
AS
SELECT
  [HRAppDB].[Employees].[ID],
  [HRAppDB].[Employees].[Photo],
  [HRAppDB].[Employees].[FirstName],
  [HRAppDB].[Employees].[LastName],
  [HRAppDB].[Employees].[RegistationDate],
  [HRAppDB].[Employees].[IsActual],
  [HRAppDB].[Projects].[ID],
  [HRAppDB].[Projects].[Title],
  [HRAppDB].[Projects].[Description],
  [HRAppDB].[Projects].[DirectionID],
  [HRAppDB].[Directions].[ID],
  [HRAppDB].[Directions].[Title],
  [HRAppDB].[Directions].[Description]
FROM [HRAppDB].[Employees]
JOIN [HRAppDB].[Employees_Projects]
  ON [HRAppDB].[Employees].[ID] = [HRAppDB].[Employees_Projects].[EmployeeID]
JOIN [HRAppDB].[Projects]
  ON [HRAppDB].[Projects].[ID] = [HRAppDB].[Employees_Projects].[ProjectID]
JOIN [HRAppDB].[Directions]
  ON [HRAppDB].[Projects].[DirectionID] = [HRAppDB].[Directions].[ID]
