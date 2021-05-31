CREATE PROCEDURE [HRAppDB].[DeleteCity]
	@ID int
AS
	DELETE
	FROM [HRAppDB].[Cities]
	WHERE [HRAppDB].[Cities].[ID] = @ID