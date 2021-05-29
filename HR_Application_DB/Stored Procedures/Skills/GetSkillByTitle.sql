CREATE PROCEDURE [HRAppDB].[GetSkillByTitle]
	@Title nvarchar
AS
	SELECT * FROM [HRAppDB].[Skills]
	WHERE [HRAppDB].[Skills].[Title] = @Title
