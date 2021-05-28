CREATE PROCEDURE [dbo].[GetRequirements]
AS
	SELECT [dbo].[Requirements].[ID],
	[dbo].[Requirements].[SkillID],
	[dbo].[Requirements].[LevelSkillID],
	[dbo].[Requirements].[AmountOfEmployees]
	FROM [dbo].[Requirements]