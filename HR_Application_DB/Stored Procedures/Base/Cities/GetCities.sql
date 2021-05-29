CREATE PROCEDURE [HRAppDB].[GetCities]
AS
	SELECT [HRAppDB].[Cities].[ID], [HRAppDB].[Cities].[Name], [HRAppDB].[Cities].[CountryID]
	FROM [HRAppDB].[Cities]