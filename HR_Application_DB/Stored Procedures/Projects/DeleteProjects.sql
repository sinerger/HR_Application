CREATE PROCEDURE [dbo].[DeleteProjects]
	@ID int
AS
	DELETE
	FROM [dbo].[Projects]
	WHERE [dbo].[Projects].[ID] = @ID