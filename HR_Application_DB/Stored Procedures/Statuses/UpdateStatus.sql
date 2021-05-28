CREATE PROCEDURE [dbo].[UpdateStatus]
	@ID int,
	@Name nvarchar
AS
	UPDATE [dbo].[Statuses]
	SET [dbo].[Statuses].[Name] = @Name
	WHERE [dbo].[Skills].[ID] = @ID