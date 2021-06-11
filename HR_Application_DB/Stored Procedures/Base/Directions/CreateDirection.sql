CREATE PROCEDURE [HRAppDB].[CreateDirection]
	@Title nvarchar (255),
	@Description nvarchar (255)
AS
	insert into [HRAppDB].[Directions]
	values(
	@Title,
	@Description)
