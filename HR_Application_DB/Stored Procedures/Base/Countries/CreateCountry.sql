CREATE PROCEDURE [HRAppDB].[CreateCountry]
	@Name nvarchar (255)
AS
	insert into [HRAppDB].[Countries]
	values (@Name)