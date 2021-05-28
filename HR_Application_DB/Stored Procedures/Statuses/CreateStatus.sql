CREATE PROCEDURE [dbo].[CreateStatus]
	@Name nvarchar
AS
INSERT INTO [dbo].Statuses
	VALUES (@Name)