CREATE PROCEDURE [dbo].[UpdateLevelSkills]
@ID int,
@Title nvarchar(255)
AS
UPDATE [dbo].[LevelSkills]
SET [dbo].[LevelSkills].Title=@Title
    WHERE [dbo].[LevelSkills].ID=@ID