CREATE PROCEDURE [HRAppDB].[DeleteLevelSkills]
@ID int
AS
DELETE
FROM [HRAppDB].[LevelSkills]
WHERE [HRAppDB].[LevelSkills].ID=@ID