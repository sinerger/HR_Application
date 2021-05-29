CREATE PROCEDURE [HRAppDB].[GetLocationsByID]
@ID int
AS
SELECT * FROM [HRAppDB].[Locations]
WHERE [HRAppDB].[Locations].ID=@ID 