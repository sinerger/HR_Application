CREATE PROCEDURE [HRAppDB].[UpdateLevelPosition]
	@ID int,
	@Title nvarchar,
	@Description nvarchar
AS
UPDATE [HRAppDB].[LevelPositions]
SET [HRAppDB].[LevelPositions].[Title] = @Title,
	[HRAppDB].[LevelPositions].[Description] = @Description
WHERE [HRAppDB].[LevelPositions].[ID] = @ID

