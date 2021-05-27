CREATE PROCEDURE [dbo].[crud_RequirementsCreate]
	@SkillID int,
	@LevelSkillID int,
	@AmountOfEmployees int
AS
	INSERT INTO [dbo].[Requirements] (
	[dbo].[Requirements].[SkillID],
	[dbo].[Requirements].[LevelSkillID],
	[dbo].[Requirements].[AmountOfEmployees]
	)
	VALUES (
		@SkillID,
		@LevelSkillID,
		@AmountOfEmployees
	)