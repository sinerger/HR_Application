CREATE PROCEDURE [HRAppDB].[DeleteLevelPosition]
	@ID int
AS
	DELETE
	FROM [HRAppDB].[LevelPosition]
	WHERE [HRAppDB].[LevelPosition].[ID] = @ID
