CREATE PROCEDURE [HRAppDB].[GetLevelPositionsByID]
	@ID int
AS
	SELECT * FROM [HRAppDB].[LevelPositions]
	WHERE [HRAppDB].[LevelPositions].ID = @ID 