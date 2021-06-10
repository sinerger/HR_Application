CREATE PROCEDURE [HRAppDB].[CreateDepartmentsProjects]
	@ProjectID int,
	@DepartmentID int,
	@IsActual bit

AS
	insert into [HRAppDB].[Departments_Projects]
	values (
	@ProjectID,
	@DepartmentID,
	@IsActual)
