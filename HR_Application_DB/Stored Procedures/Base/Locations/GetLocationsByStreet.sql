CREATE PROCEDURE [HRAppDB].[GetLocationsByStreet]
@Street nvarchar (255)
AS
SELECT * FROM [HRAppDB].[Locations]
WHERE [HRAppDB].[Locations].Street=@Street
