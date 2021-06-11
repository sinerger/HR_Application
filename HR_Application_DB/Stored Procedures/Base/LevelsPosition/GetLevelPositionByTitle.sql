CREATE PROCEDURE [HRAppDB].[GetLevelPositionByTitle]
	@Title nvarchar (255)
AS
	SELECT * FROM [HRAppDB].[LevelPosition]
	WHERE [HRAppDB].[LevelPosition].Title = @Title

