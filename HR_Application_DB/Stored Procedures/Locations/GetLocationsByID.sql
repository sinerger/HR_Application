CREATE PROCEDURE [dbo].[GetLocationsByID]
@ID int
AS
SELECT * FROM [dbo].[Locations]
WHERE [dbo].[Locations].ID=@ID 