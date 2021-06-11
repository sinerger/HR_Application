CREATE PROCEDURE [HRAppDB].[GetSkillByTitle]
	@Title nvarchar (255)
AS
	SELECT * FROM [HRAppDB].[Skills]
	WHERE [HRAppDB].[Skills].[Title] = @Title
