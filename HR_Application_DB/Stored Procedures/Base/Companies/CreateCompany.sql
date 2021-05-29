CREATE PROCEDURE [HRAppDB].[CreateCompany]
	@Title nvarchar,
	@LocationID int,
	@Description nvarchar
AS
	insert into [HRAppDB].[Companies]
	values (
	@Title,
	@LocationID,
	@Description)
