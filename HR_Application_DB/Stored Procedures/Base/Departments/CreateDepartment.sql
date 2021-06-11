CREATE PROCEDURE [HRAppDB].[CreateDepartment]
	@Title nvarchar (255),
	@Description nvarchar (255)
AS
	insert into [HRAppDB].[Departments]
	values (
	@Title,
	@Description)