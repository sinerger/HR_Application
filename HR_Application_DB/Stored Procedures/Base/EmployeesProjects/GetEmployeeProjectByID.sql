CREATE PROCEDURE [HRAppDB].[GetEmployeeProjectByID]
	@ID int
AS
	SELECT * FROM [HRAppDB].[Employees_Projects]
	WHERE [HRAppDB].[Employees_Projects].ID=@ID 
