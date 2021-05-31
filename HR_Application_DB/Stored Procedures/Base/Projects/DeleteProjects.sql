CREATE PROCEDURE [HRAppDB].[DeleteProjects]
	@ID int
AS
	DELETE
	FROM [HRAppDB].[Projects]
	WHERE [HRAppDB].[Projects].[ID] = @ID