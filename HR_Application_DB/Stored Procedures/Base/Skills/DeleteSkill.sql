CREATE PROCEDURE [HRAppDB].[DeleteSkill]
	@ID int
AS
	DELETE
	FROM [HRAppDB].[Skills]
	WHERE [HRAppDB].[Skills].[ID] = @ID