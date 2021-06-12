CREATE PROCEDURE [HRAppDB].[GetEmployeeSkillByID]
	@ID int
AS
SELECT*FROM [HRAppDB].[Employees_Skills]
WHERE [HRAppDB].[Employees_Skills].ID =@ID