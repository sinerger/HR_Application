CREATE PROCEDURE [dbo].[GetProjectByTitle]
	@Title nvarchar
AS
	SELECT * FROM [dbo].[Projects]
	WHERE [dbo].[Projects].[Title] = @Title
