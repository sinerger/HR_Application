CREATE PROCEDURE [dbo].[GetLevelSkillsByTitle]
@Title nvarchar
AS
	SELECT * FROM [dbo].[LevelSkills]
	WHERE [dbo].[LevelSkills].Title=@Title