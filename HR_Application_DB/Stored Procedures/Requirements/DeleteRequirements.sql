CREATE PROCEDURE [dbo].[DeleteRequirements]
	@ID int
AS
	DELETE
	FROM [dbo].[Requirements]
	WHERE [dbo].[Requirements].[ID] = @ID
