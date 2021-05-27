CREATE PROCEDURE [dbo].[crud_SkillsRead]
AS
	SELECT [dbo].[Skills].[ID],
	[dbo].[Skills].[Title],
	[dbo].[Skills].[Description]
	FROM [dbo].[Skills]
