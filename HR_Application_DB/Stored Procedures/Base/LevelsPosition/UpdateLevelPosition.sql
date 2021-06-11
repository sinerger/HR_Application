CREATE PROCEDURE [HRAppDB].[UpdateLevelPosition]
	@ID int,
	@Title nvarchar,
	@Description nvarchar
AS
UPDATE [HRAppDB].[LevelPosition]
SET [HRAppDB].[LevelPosition].[Title] = @Title,
	[HRAppDB].[LevelPosition].[Description] = @Description
WHERE [HRAppDB].[LevelPosition].[ID] = @ID

