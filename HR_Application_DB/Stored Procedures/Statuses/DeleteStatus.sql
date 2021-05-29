CREATE PROCEDURE [HRAppDB].[DeleteStatus]
	@ID int
AS
	DELETE
	FROM [HRAppDB].[Statuses]
	WHERE [HRAppDB].[Statuses].[ID] = @ID