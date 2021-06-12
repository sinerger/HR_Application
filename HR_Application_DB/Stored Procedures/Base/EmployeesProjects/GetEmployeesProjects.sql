CREATE PROCEDURE [HRAppDB].[GetEmployeesProjects]
	AS
SELECT 
[HRAppDB].[Employees_Projects].ID,
[HRAppDB].[Employees_Projects].EmployeeID,
[HRAppDB].[Employees_Projects].StartDate,
[HRAppDB].[Employees_Projects].EndDate,
[HRAppDB].[Employees_Projects].IsActual,
[HRAppDB].[Employees_Projects].ProjectID as ID
FROM [HRAppDB].[Employees_Projects]