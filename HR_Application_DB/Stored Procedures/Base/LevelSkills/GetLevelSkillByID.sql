CREATE PROCEDURE [HRAppDB].[GetLevelSkillByID]
@ID int
AS
	SELECT * FROM [HRAppDB].[LevelSkills]
	WHERE [HRAppDB].[LevelSkills].ID=@ID 