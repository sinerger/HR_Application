CREATE PROCEDURE [HRAppDB].[GetProjectByTitle]
	@Title nvarchar
AS
	SELECT * FROM [HRAppDB].[Projects]
	WHERE [HRAppDB].[Projects].[Title] = @Title
