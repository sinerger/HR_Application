CREATE PROCEDURE [HRAppDB].[GetDepartmentByID]
	@ID int
AS
	select * from [HRAppDB].[Departments]
	where [HRAppDB].[Departments].ID=@ID
