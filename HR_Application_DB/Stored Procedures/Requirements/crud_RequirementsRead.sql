CREATE PROCEDURE [dbo].[crud_RequirementsRead]
AS
	SELECT [dbo].[Requirements].[ID],
	[dbo].[Requirements].[SkillID],
	[dbo].[Requirements].[LevelSkillID],
	[dbo].[Requirements].[AmountOfEmployees]
	FROM [dbo].[Requirements]