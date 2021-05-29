CREATE PROCEDURE [dbo].[DeleteLevelPosition]
	@ID int
AS
	DELETE
	FROM [dbo].[LevelPositions]
	WHERE [dbo].[LevelPositions].[ID] = @ID
