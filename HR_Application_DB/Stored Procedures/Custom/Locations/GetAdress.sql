CREATE PROCEDURE [HRAppDB].[GetAdress]
AS
SELECT 
lo.ID as IDLocations,
lo.Street,
lo.HouseNumber,
lo.[Block],
lo.ApartmentNumber,
lo.PostIndex,
ci.ID as IDCities,
ci.[Name] as NameCities,
co.ID as IDCountries,
co.[Name] as NameCountries

FROM [HRAppDB].[Locations] as lo

INNER JOIN [HRAppDB].[Cities] as ci
ON
lo.CityID=ci.ID

INNER JOIN [HRAppDB].[Countries] as co
ON
ci.CountryID=co.ID