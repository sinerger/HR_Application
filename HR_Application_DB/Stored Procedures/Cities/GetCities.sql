CREATE PROCEDURE [dbo].[GetCities]
AS
	SELECT [dbo].[Cities].[ID], [dbo].[Cities].[Name], [dbo].[Cities].[CountryID]
	FROM [dbo].[Cities]