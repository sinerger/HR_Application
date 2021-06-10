CREATE PROCEDURE [HRAppDB].[GetDepartmentProjectsByDepartmentID]
@ID int
AS
SELECT 
	[HRAppDB].[Departments_Projects].ID, 
	[HRAppDB].[Departments_Projects].DepartmentID, 
	[HRAppDB].[Departments_Projects].IsActual, 
	[HRAppDB].[Departments_Projects].ProjectID

FROM [HRAppDB].[Departments_Projects]

WHERE [HRAppDB].[Departments_Projects].[ID] = @ID