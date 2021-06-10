CREATE PROCEDURE [HRAppDB].[GetEmployeePositionByID]
@ID int
AS
SELECT * FROM [HRAppDB].[Positions_Employees]
WHERE [HRAppDB].[Positions_Employees].[ID] = @ID