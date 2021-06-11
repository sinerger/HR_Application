CREATE PROCEDURE [HRAppDB].[DeleteLevelsPosition]
	@ID int
AS
	DELETE
	FROM [HRAppDB].[LevelsPosition]
	WHERE [HRAppDB].[LevelsPosition].[ID] = @ID
