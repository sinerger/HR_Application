CREATE PROCEDURE [HRAppDB].[GetCityByName]
	@Name nvarchar
AS
	SELECT [HRAppDB].[Cities].[ID], [HRAppDB].[Cities].[Name], [HRAppDB].[Cities].[CountryID]
	FROM [HRAppDB].[Cities]
	WHERE [HRAppDB].[Cities].[Name] = @Name
