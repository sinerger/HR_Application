CREATE PROCEDURE [dbo].[crud_RequirementsDelete]
	@ID int
AS
	DELETE
	FROM [dbo].[Requirements]
	WHERE [dbo].[Requirements].[ID] = @ID
