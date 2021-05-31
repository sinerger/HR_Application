CREATE PROCEDURE [HRAppDB].[GetAdress]
AS
SELECT 
lo.ID,
lo.Street,
lo.HouseNumber,
lo.[Block],
lo.ApartmentNumber,
lo.PostIndex,
ci.ID,
ci.[Name],
ci.CountryID,
co.ID,
co.[Name]

FROM [HRAppDB].[Locations] as lo

INNER JOIN [HRAppDB].[Cities] as ci
ON
lo.CityID=ci.ID

INNER JOIN [HRAppDB].[Countries] as co
ON
ci.CountryID=co.ID