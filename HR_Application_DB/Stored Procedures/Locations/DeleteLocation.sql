CREATE PROCEDURE [HRAppDB].[DeleteLocation]
	@ID int
AS
	DELETE
	FROM [HRAppDB].[Locations]
	WHERE [HRAppDB].[Locations].[ID] = @ID
