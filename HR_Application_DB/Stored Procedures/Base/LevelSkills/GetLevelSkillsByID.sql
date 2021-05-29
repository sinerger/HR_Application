CREATE PROCEDURE [HRAppDB].[GetLevelSkillsByID]
@ID int
AS
	SELECT * FROM [HRAppDB].[LevelSkills]
	WHERE [HRAppDB].[LevelSkills].ID=@ID 