CREATE PROCEDURE [HRAppDB].[GetLevelsPositionByID]
	@ID int
AS
	SELECT * FROM [HRAppDB].[LevelsPosition]
	WHERE [HRAppDB].[LevelsPosition].ID = @ID 