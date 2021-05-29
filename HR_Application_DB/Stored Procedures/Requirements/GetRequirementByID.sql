CREATE PROCEDURE [HRAppDB].[GetRequirementByID]
	@ID int
AS
	SELECT * FROM [HRAppDB].[Requirements]
	WHERE [HRAppDB].[Requirements].[ID] = @ID
