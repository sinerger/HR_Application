CREATE PROCEDURE [dbo].[GetProjectByID]
	@ID int
AS
	SELECT * FROM [dbo].[Projects]
	WHERE [dbo].[Projects].[ID] = @ID
