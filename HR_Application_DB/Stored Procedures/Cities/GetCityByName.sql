CREATE PROCEDURE [dbo].[GetCityByName]
	@Name nvarchar
AS
	SELECT [dbo].[Cities].[ID], [dbo].[Cities].[Name], [dbo].[Cities].[CountryID]
	FROM [dbo].[Cities]
	WHERE [dbo].[Cities].[Name] = @Name
