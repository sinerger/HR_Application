CREATE PROCEDURE [dbo].[GetEmployeeProjects]
AS
SELECT
  [dbo].[Employees].[ID],
  [dbo].[Employees].[Photo],
  [dbo].[Employees].[FirstName],
  [dbo].[Employees].[LastName],
  [dbo].[Employees].[RegistationDate],
  [dbo].[Employees].[IsActual],
  [dbo].[Projects].[ID],
  [dbo].[Projects].[Title],
  [dbo].[Projects].[Description],
  [dbo].[Projects].[DirectionID],
  [dbo].[Directions].[ID],
  [dbo].[Directions].[Title],
  [dbo].[Directions].[Description]
FROM [dbo].[Employees]
JOIN [dbo].[Employees_Projects]
  ON [dbo].[Employees].[ID] = [dbo].[Employees_Projects].[EmployeeID]
JOIN [dbo].[Projects]
  ON [dbo].[Projects].[ID] = [dbo].[Employees_Projects].[ProjectID]
JOIN [dbo].[Directions]
  ON [dbo].[Projects].[DirectionID] = [dbo].[Directions].[ID]
