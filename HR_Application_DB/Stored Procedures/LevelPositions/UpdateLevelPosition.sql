CREATE PROCEDURE [dbo].[UpdateLevelPosition]
	@ID int,
	@Title nvarchar,
	@Description nvarchar
AS
UPDATE [dbo].[LevelPositions]
SET [dbo].[LevelPositions].[Title] = @Title,
	[dbo].[LevelPositions].[Description] = @Description
WHERE [dbo].[LevelPositions].[ID] = @ID

