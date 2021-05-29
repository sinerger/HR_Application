CREATE PROCEDURE [HRAppDB].[GetProjectByID]
	@ID int
AS
	SELECT * FROM [HRAppDB].[Projects]
	WHERE [HRAppDB].[Projects].[ID] = @ID
