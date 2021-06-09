CREATE PROCEDURE [HRAppDB].[CreateLevelSkill]
@Title nvarchar
AS
INSERT INTO [HRAppDB].[LevelSkills](
[HRAppDB].[LevelSkills].Title)
VALUES(
@Title)