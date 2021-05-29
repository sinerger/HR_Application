CREATE PROCEDURE [HRAppDB].[GetSkillByID]
	@ID int
	
AS
	SELECT * FROM [HRAppDB].[Skills]
	WHERE [HRAppDB].[Skills].[ID] = @ID