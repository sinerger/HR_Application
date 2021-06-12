CREATE PROCEDURE [HRAppDB].[CreateCompany]
	@Title nvarchar (255),
	@LocationID int,
	@Description nvarchar (255),
	@IsActual bit
AS
	insert into [HRAppDB].[Companies]
	OUTPUT INSERTED.[ID]
	values (
	@Title,
	@LocationID,
	@Description,
	@IsActual)
