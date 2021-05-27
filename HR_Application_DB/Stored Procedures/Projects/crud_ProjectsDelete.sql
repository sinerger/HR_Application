CREATE PROCEDURE [dbo].[crud_ProjectsDelete]
	@ID int
AS
	DELETE
	FROM [dbo].[Projects]
	WHERE [dbo].[Projects].[ID] = @ID