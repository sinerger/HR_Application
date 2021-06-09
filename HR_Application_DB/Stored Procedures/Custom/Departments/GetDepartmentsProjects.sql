CREATE PROCEDURE [HRAppDB].[GetDepartmentsProjects]
AS
SELECT 
 
	[HRAppDB].[Departments_Projects].ID, 
	[HRAppDB].[Departments_Projects].DepartmentID, 
	[HRAppDB].[Departments_Projects].IsActual, 
	[HRAppDB].[Departments_Projects].ProjectID

FROM [HRAppDB].[Departments_Projects]