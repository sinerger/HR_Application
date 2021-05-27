CREATE PROCEDURE [dbo].[crud_SkillsUpdate]
	@ID int,
	@Title nvarchar,
	@Description nvarchar
AS
	UPDATE [dbo].[Skills]
	SET [dbo].[Skills].[Title] = @Title,
	[dbo].[Skills].[Description] = @Description
	WHERE [dbo].[Skills].[ID] = @ID