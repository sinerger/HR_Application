CREATE PROCEDURE [dbo].[GetLevelSkillsByID]
@ID int
AS
	SELECT * FROM [dbo].[LevelSkills]
	WHERE [dbo].[LevelSkills].ID=@ID 