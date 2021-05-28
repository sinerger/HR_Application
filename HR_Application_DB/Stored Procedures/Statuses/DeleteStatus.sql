CREATE PROCEDURE [dbo].[DeleteStatus]
	@ID int
AS
	DELETE
	FROM [dbo].[Statuses]
	WHERE [dbo].[Statuses].[ID] = @ID