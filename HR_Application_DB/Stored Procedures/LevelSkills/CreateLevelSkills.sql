CREATE PROCEDURE [HRAppDB].[CreateLevelSkills]
@ID int,
@Title nvarchar(255)
AS
INSERT INTO [HRAppDB].[LevelSkills](
[HRAppDB].[LevelSkills].ID,
[HRAppDB].[LevelSkills].Title)
VALUES(
@ID,
@Title)