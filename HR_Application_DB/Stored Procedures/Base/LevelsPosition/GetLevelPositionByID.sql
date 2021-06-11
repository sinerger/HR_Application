CREATE PROCEDURE [HRAppDB].[GetLevelPositionByID]
	@ID int
AS
	SELECT * FROM [HRAppDB].[LevelPosition]
	WHERE [HRAppDB].[LevelPosition].ID = @ID 