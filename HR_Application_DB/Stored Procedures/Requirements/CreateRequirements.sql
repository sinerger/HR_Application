CREATE PROCEDURE [HRAppDB].[CreateRequirements]
	@SkillID int,
	@LevelSkillID int,
	@AmountOfEmployees int
AS
	INSERT INTO [HRAppDB].[Requirements] (
	[HRAppDB].[Requirements].[SkillID],
	[HRAppDB].[Requirements].[LevelSkillID],
	[HRAppDB].[Requirements].[AmountOfEmployees]
	)
	VALUES (
		@SkillID,
		@LevelSkillID,
		@AmountOfEmployees
	)