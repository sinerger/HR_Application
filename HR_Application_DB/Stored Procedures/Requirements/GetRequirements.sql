CREATE PROCEDURE [HRAppDB].[GetRequirements]
AS
	SELECT [HRAppDB].[Requirements].[ID],
	[HRAppDB].[Requirements].[SkillID],
	[HRAppDB].[Requirements].[LevelSkillID],
	[HRAppDB].[Requirements].[AmountOfEmployees]
	FROM [HRAppDB].[Requirements]