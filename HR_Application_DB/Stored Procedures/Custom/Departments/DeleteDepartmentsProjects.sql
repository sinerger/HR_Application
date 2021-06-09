CREATE PROCEDURE [HRAppDB].[DeleteDepartmentsProjects]
	@ID int 
AS
	delete from [HRAppDB].[Departments_Projects]
	where [HRAppDB].[Departments_Projects].ID = @ID
