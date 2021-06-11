CREATE PROCEDURE [HRAppDB].[GetLevelPositionByTitle]
	@Title nvarchar
AS
	SELECT * FROM [HRAppDB].[LevelPosition]
	WHERE [HRAppDB].[LevelPosition].Title = @Title

