CREATE PROCEDURE [HRAppDB].[GetLevelSkillByTitle]
@Title nvarchar
AS
	SELECT * FROM [HRAppDB].[LevelSkills]
	WHERE [HRAppDB].[LevelSkills].Title=@Title