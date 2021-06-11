CREATE PROCEDURE [HRAppDB].[UpdateLevelSkill]
@ID int,
@Title nvarchar (255)
AS
UPDATE [HRAppDB].[LevelSkills]
SET [HRAppDB].[LevelSkills].Title=@Title
    WHERE [HRAppDB].[LevelSkills].ID=@ID