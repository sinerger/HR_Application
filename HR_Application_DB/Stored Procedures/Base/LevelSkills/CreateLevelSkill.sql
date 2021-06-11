CREATE PROCEDURE [HRAppDB].[CreateLevelSkill]
@Title nvarchar (255)
AS
INSERT INTO [HRAppDB].[LevelSkills](
[HRAppDB].[LevelSkills].Title)
VALUES(
@Title)