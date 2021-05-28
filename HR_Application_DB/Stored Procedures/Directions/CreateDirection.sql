CREATE PROCEDURE [dbo].[CreateDirection]
	@Title nvarchar,
	@Description nvarchar
AS
	insert into [dbo].[Directions]
	values(
	@Title,
	@Description)
