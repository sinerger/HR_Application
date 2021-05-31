CREATE PROCEDURE [HRAppDB].[UpdateLevelSkills]
@ID int,
@Title nvarchar
AS
UPDATE [HRAppDB].[LevelSkills]
SET [HRAppDB].[LevelSkills].Title=@Title
    WHERE [HRAppDB].[LevelSkills].ID=@ID