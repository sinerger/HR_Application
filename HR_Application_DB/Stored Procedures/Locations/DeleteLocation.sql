CREATE PROCEDURE [dbo].[DeleteLocation]
	@ID int
AS
	DELETE
	FROM [dbo].[Locations]
	WHERE [dbo].[Locations].[ID] = @ID
