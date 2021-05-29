CREATE PROCEDURE [HRAppDB].[UpdateDepartment]
	@ID int,
	@Title nvarchar,
	@Description nvarchar
AS
	Update [HRAppDB].[Departments]
	set
	[HRAppDB].[Departments].Title = @Title,
	[HRAppDB].[Departments].[Description] = @Description
	where 
	[HRAppDB].[Departments].ID = @ID