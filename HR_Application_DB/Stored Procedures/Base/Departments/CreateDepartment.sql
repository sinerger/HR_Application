CREATE PROCEDURE [HRAppDB].[CreateDepartment]
	@Title nvarchar (255) null,
	@Description nvarchar (255) null
AS
	insert into [HRAppDB].[Departments]
	OUTPUT INSERTED.[ID]
	values (
	@Title,
	@Description)