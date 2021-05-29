CREATE PROCEDURE [HRAppDB].[CreateDepartment]
	@Title nvarchar,
	@Description nvarchar
AS
	insert into [HRAppDB].[Departments]
	values (
	@Title,
	@Description)