CREATE PROCEDURE [HRAppDB].[DeleteLevelPosition]
	@ID int
AS
	DELETE
	FROM [HRAppDB].[LevelPositions]
	WHERE [HRAppDB].[LevelPositions].[ID] = @ID
