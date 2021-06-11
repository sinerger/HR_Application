CREATE PROCEDURE [HRAppDB].[UpdateDepartment]
	@ID int,
	@Title nvarchar (255),
	@Description nvarchar (255)
AS
	Update [HRAppDB].[Departments]
	set
	[HRAppDB].[Departments].Title = @Title,
	[HRAppDB].[Departments].[Description] = @Description
	where 
	[HRAppDB].[Departments].ID = @ID