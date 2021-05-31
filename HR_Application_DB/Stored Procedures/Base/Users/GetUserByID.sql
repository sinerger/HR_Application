CREATE PROCEDURE [HRAppDB].[GetUserByID]
	@ID int
	AS
	SELECT * FROM [HRAppDB].[Users]
	WHERE [HRAppDB].[Users].[ID] = @ID
