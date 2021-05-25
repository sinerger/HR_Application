CREATE PROCEDURE [dbo].[GetCityByName]
	@name nvarchar

AS
	
	select * from [dbo].[Cities]
	where [dbo].[Cities].[Name] = @name