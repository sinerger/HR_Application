CREATE PROCEDURE [HRAppDB].[UpdateStatus]
	@ID int,
	@Name nvarchar
AS
	UPDATE [HRAppDB].[Statuses]
	SET [HRAppDB].[Statuses].[Name] = @Name
	WHERE [HRAppDB].[Statuses].[ID] = @ID