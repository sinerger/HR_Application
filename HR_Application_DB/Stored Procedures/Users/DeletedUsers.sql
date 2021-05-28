CREATE PROCEDURE [dbo].[DeleteUsers]
	@ID int
AS
	DELETE
	FROM [dbo].[Users]
	WHERE [dbo].[Users].[ID] = @ID