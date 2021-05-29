CREATE PROCEDURE [HRAppDB].[UpdateRequirements]
	@ID int,
	@SkillID int,
	@LevelSkillID int,
	@AmountOfEmployees int
AS
	UPDATE [HRAppDB].[Requirements]
	SET
		[HRAppDB].[Requirements].[SkillID] = @SkillID,
		[HRAppDB].[Requirements].[LevelSkillID] = @LevelSkillID,
		[HRAppDB].[Requirements].[AmountOfEmployees] = @AmountOfEmployees
	WHERE [HRAppDB].[Requirements].[ID] = @ID