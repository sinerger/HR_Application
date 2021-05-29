CREATE PROCEDURE [HRAppDB].[CreateDirection]
	@Title nvarchar,
	@Description nvarchar
AS
	insert into [HRAppDB].[Directions]
	values(
	@Title,
	@Description)
