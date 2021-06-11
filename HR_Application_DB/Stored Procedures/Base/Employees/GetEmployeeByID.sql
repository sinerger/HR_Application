CREATE PROCEDURE [HRAppDB].[GetEmployeeByID]
	@ID int
AS
	SELECT [HRAppDB].[Employees].*
	FROM [HRAppDB].[Employees]
	WHERE [HRAppDB].[Employees].[ID] = @ID