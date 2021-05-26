CREATE PROCEDURE [dbo].[GetRequirementByID]
	@ID int
AS
	SELECT * FROM [dbo].[Requirements]
	WHERE [dbo].[Requirements].[ID] = @ID
