CREATE PROCEDURE [dbo].[DeleteCity]
	@ID int
AS
	DELETE
	FROM [dbo].[Cities]
	WHERE [dbo].[Cities].[ID] = @ID