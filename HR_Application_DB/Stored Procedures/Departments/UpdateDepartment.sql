CREATE PROCEDURE [dbo].[UpdateDepartment]
	@ID int,
	@Title nvarchar,
	@Description nvarchar
AS
	Update [dbo].[Departments]
	set
	[dbo].[Departments].Title = @Title,
	[dbo].[Departments].[Description] = @Description
	where 
	[dbo].[Departments].ID = @ID