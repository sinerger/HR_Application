CREATE PROCEDURE [HRAppDB].[GetEmployeeByID]
	@ID int
AS
	select * from [HRAppDB].[Employees]
	where [HRAppDB].[Employees].[ID] = @ID