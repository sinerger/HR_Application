CREATE PROCEDURE [HRAppDB].[UpdateLevelPosition]
	@ID int,
	@Title nvarchar (255),
	@Description nvarchar (255)
AS
UPDATE [HRAppDB].[LevelPosition]
SET [HRAppDB].[LevelPosition].[Title] = @Title,
	[HRAppDB].[LevelPosition].[Description] = @Description
WHERE [HRAppDB].[LevelPosition].[ID] = @ID

