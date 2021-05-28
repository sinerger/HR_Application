CREATE PROCEDURE [dbo].[CreateDepartment]
	@Title nvarchar,
	@Description nvarchar
AS
	insert into [dbo].[Departments]
	values (
	@Title,
	@Description)