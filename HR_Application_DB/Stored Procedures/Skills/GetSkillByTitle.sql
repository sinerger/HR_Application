CREATE PROCEDURE [dbo].[GetSkillByTitle]
	@Title nvarchar
AS
	SELECT * FROM [dbo].[Skills]
	WHERE [dbo].[Skills].[Title] = @Title
