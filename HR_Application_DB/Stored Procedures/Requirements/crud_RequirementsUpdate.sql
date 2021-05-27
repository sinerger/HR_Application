CREATE PROCEDURE [dbo].[crud_RequirementsUpdate]
	@ID int,
	@SkillID int,
	@LevelSkillID int,
	@AmountOfEmployees int
AS
	UPDATE [dbo].[Requirements]
	SET
		[dbo].[Requirements].[SkillID] = @SkillID,
		[dbo].[Requirements].[LevelSkillID] = @LevelSkillID,
		[dbo].[Requirements].[AmountOfEmployees] = @AmountOfEmployees
	WHERE [dbo].[Users].[ID] = @ID