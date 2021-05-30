CREATE PROCEDURE [HRAppDB].[CreateCompany]
	@Title nvarchar,
	@LocationID int,
	@Description nvarchar,
	@IsActual bit
AS
	insert into [HRAppDB].[Companies]
	values (
	@Title,
	@LocationID,
	@Description,
	@IsActual)
