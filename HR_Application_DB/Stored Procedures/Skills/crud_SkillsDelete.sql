CREATE PROCEDURE [dbo].[crud_SkillsDelete]
	@ID int
AS
	DELETE
	FROM [dbo].[Skills]
	WHERE [dbo].[Skills].[ID] = @ID