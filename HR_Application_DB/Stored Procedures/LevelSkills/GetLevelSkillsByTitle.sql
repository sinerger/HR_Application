CREATE PROCEDURE [HRAppDB].[GetLevelSkillsByTitle]
@Title nvarchar
AS
	SELECT * FROM [HRAppDB].[LevelSkills]
	WHERE [HRAppDB].[LevelSkills].Title=@Title