CREATE PROCEDURE [dbo].[CreateCountry]
	@Name nvarchar
AS
	insert into [dbo].[Countries]
	values (@Name)