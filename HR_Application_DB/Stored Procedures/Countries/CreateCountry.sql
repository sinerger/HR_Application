CREATE PROCEDURE [HRAppDB].[CreateCountry]
	@Name nvarchar
AS
	insert into [HRAppDB].[Countries]
	values (@Name)