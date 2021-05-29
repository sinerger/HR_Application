CREATE PROCEDURE [HRAppDB].[UpdateSkillByID]
	@ID int,
	@Title nvarchar,
	@Description nvarchar
AS
	UPDATE [HRAppDB].[Skills]
	SET [HRAppDB].[Skills].[Title] = @Title,
	[HRAppDB].[Skills].[Description] = @Description
	WHERE [HRAppDB].[Skills].[ID] = @ID