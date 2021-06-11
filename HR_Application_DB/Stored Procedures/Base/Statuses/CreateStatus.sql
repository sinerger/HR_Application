CREATE PROCEDURE [HRAppDB].[CreateStatus]
	@Name nvarchar (255)
AS
INSERT INTO [HRAppDB].Statuses
	VALUES (@Name)