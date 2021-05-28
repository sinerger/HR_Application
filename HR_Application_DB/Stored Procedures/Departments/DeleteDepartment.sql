CREATE PROCEDURE [dbo].[DeleteDepartment]
	@ID int
AS
	delete from [dbo].[Departments]
	where [dbo].[Departments].ID = @ID
