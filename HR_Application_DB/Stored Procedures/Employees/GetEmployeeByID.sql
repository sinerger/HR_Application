CREATE PROCEDURE [dbo].[GetEmployeeByID]
	@ID int
AS
	select * from [dbo].[Employees]
	where [dbo].[Employees].[ID] = @ID