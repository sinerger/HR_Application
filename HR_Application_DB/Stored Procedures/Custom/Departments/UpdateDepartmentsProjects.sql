CREATE PROCEDURE [HRAppDB].[UpdateDepartmentsProjects]
	@ID int,
	@ProjectID int,
	@DepartmentID int
AS
	Update [HRAppDB].[Departments_Projects]
	set
	[HRAppDB].[Departments_Projects].ProjectID = @ProjectID,
	[HRAppDB].[Departments_Projects].DepartmentID = @ProjectID
	where 
	[HRAppDB].[Departments_Projects].ID = @ID
