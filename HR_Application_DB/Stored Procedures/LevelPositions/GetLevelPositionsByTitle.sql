CREATE PROCEDURE [HRAppDB].[GetLevelPositionsByTitle]
	@Title nvarchar
AS
	SELECT * FROM [HRAppDB].[LevelPositions]
	WHERE [HRAppDB].[LevelPositions].Title = @Title

