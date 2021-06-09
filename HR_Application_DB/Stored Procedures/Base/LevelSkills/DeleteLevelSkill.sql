CREATE PROCEDURE [HRAppDB].[DeleteLevelSkill]
@ID int
AS
DELETE
FROM [HRAppDB].[LevelSkills]
WHERE [HRAppDB].[LevelSkills].ID=@ID