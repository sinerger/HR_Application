CREATE PROCEDURE [HRAppDB].[UpdateLevelsPosition]
	@ID int,
	@Title nvarchar,
	@Description nvarchar
AS
UPDATE [HRAppDB].[LevelsPosition]
SET [HRAppDB].[LevelsPosition].[Title] = @Title,
	[HRAppDB].[LevelsPosition].[Description] = @Description
WHERE [HRAppDB].[LevelsPosition].[ID] = @ID

