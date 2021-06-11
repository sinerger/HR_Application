CREATE PROCEDURE [HRAppDB].[UpdateSkill]
	@ID int,
	@Title nvarchar (255),
	@Description nvarchar (255)
AS
	UPDATE [HRAppDB].[Skills]
	SET [HRAppDB].[Skills].[Title] = @Title,
	[HRAppDB].[Skills].[Description] = @Description
	WHERE [HRAppDB].[Skills].[ID] = @ID