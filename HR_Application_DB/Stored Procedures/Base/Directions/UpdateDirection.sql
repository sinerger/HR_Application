CREATE PROCEDURE [HRAppDB].[UpdateDirection]
	@ID int,
	@Title nvarchar (255),
	@Description nvarchar (255)
AS
	update [HRAppDB].[Directions]
	set 
	[HRAppDB].[Directions].Title = @Title,
	[HRAppDB].[Directions].[Description] = @Description
	where 
	[HRAppDB].[Directions].ID = @ID

