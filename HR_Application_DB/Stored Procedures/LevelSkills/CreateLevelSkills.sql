CREATE PROCEDURE [dbo].[CreateLevelSkills]
@ID int,
@Title nvarchar(255)
AS
INSERT INTO [dbo].[LevelSkills](
[dbo].[LevelSkills].ID,
[dbo].[LevelSkills].Title)
VALUES(
@ID,
@Title)