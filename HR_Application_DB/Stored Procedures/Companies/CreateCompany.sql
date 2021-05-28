CREATE PROCEDURE [dbo].[CreateCompany]
	@Title nvarchar,
	@LocationID int,
	@Description nvarchar
AS
	insert into [dbo].[Companies]
	values (
	@Title,
	@LocationID,
	@Description)
