CREATE PROCEDURE [HRAppDB].[DeleteUsers]
	@ID int
AS
	DELETE
	FROM [HRAppDB].[Users]
	WHERE [HRAppDB].[Users].[ID] = @ID