CREATE PROCEDURE [dbo].[crud_UsersDelete]
	@ID int
AS
	DELETE
	FROM [dbo].[Users]
	WHERE [dbo].[Users].[ID] = @ID