CREATE PROCEDURE [HRAppDB].[GetDepartmentProjectsByDepartmentID]
@ID int
AS
SELECT * FROM [HRAppDB].[Departments_Projects]
WHERE [HRAppDB].[Departments_Projects].[ID] = @ID