CREATE PROCEDURE [HRAppDB].[DeleteEmployeePosition]
	@ID int
AS
	DELETE
	FROM [HRAppDB].[Positions_Employees]
	WHERE [HRAppDB].[Positions_Employees].[ID] = @ID