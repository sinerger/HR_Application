CREATE PROCEDURE [dbo].[CreateStatus]
	@Name nvarchar
AS
	INSERT INTO [dbo].Statuses(
		[dbo].Statuses.[Name]
		)
	VALUES (
		@Name
	)
