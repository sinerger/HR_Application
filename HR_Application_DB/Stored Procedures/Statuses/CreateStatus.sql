CREATE PROCEDURE [HRAppDB].[CreateStatus]
	@Name nvarchar
AS
INSERT INTO [HRAppDB].Statuses
	VALUES (@Name)