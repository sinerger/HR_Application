CREATE PROCEDURE [HRAppDB].[GetLocationsByStreet]
@Street nvarchar
AS
SELECT * FROM [HRAppDB].[Locations]
WHERE [HRAppDB].[Locations].Street=@Street
