CREATE PROCEDURE [dbo].[UpdateDirection]
	@ID int,
	@Title nvarchar,
	@Description nvarchar
AS
	update [dbo].[Directions]
	set 
	[dbo].[Directions].Title = @Title,
	[dbo].[Directions].[Description] = @Description
	where 
	[dbo].[Directions].ID = @ID

