CREATE PROCEDURE [HRAppDB].[CreateCompany]
	@Title nvarchar (255) null,
	@LocationID int null,
	@Description nvarchar (255) null,
	@IsActual bit
AS
	insert into [HRAppDB].[Companies]
	OUTPUT INSERTED.[ID]
	values (
	@Title,
	@LocationID,
	@Description,
	@IsActual)
