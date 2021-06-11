CREATE PROCEDURE [HRAppDB].[GetLevelSkillByTitle]
@Title nvarchar (255)
AS
	SELECT * FROM [HRAppDB].[LevelSkills]
	WHERE [HRAppDB].[LevelSkills].Title=@Title