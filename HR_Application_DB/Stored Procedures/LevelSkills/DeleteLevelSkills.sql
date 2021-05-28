CREATE PROCEDURE [dbo].[DeleteLevelSkills]
@ID int
AS
DELETE
FROM [dbo].[LevelSkills]
WHERE [dbo].[LevelSkills].ID=@ID