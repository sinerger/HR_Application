CREATE PROCEDURE [HRAppDB].[DeleteDepartment]
	@ID int
AS
	delete from [HRAppDB].[Departments]
	where [HRAppDB].[Departments].ID = @ID
