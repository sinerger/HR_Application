CREATE PROCEDURE [HRAppDB].[DeleteRequirements]
	@ID int
AS
	DELETE
	FROM [HRAppDB].[Requirements]
	WHERE [HRAppDB].[Requirements].[ID] = @ID
