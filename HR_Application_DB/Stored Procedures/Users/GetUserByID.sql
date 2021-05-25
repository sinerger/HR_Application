CREATE PROCEDURE [dbo].[GetUserByID]
	@ID int
	AS
	SELECT * FROM [dbo].[Users]
	WHERE [dbo].[Users].[ID] = @ID
