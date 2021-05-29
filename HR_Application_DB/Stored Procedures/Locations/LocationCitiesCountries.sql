CREATE PROCEDURE [HRAppDB].[LocationCitiesCountries]
AS
SELECT 
lo.ID,
lo.Street,
lo.HouseNumber,
lo.[Block],
lo.ApartmentNumber,
lo.PostIndex,
ci.ID as IDCities,
ci.Name,
co.ID as IDCountries,
co.Name

FROM [HRAppDB].[Locations] as lo

INNER JOIN [HRAppDB].[Cities] as ci
ON
lo.CityID=ci.ID

INNER JOIN [HRAppDB].[Countries] as co
ON
ci.CountryID=co.ID