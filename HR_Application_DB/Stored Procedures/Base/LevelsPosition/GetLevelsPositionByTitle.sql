CREATE PROCEDURE [HRAppDB].[GetLevelsPositionByTitle]
	@Title nvarchar
AS
	SELECT * FROM [HRAppDB].[LevelsPosition]
	WHERE [HRAppDB].[LevelsPosition].Title = @Title

