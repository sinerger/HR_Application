CREATE PROCEDURE [HRAppDB].[UpdateDirection]
	@ID int,
	@Title nvarchar,
	@Description nvarchar
AS
	update [HRAppDB].[Directions]
	set 
	[HRAppDB].[Directions].Title = @Title,
	[HRAppDB].[Directions].[Description] = @Description
	where 
	[HRAppDB].[Directions].ID = @ID

