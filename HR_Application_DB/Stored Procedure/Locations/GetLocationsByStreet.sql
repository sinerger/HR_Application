CREATE PROCEDURE [dbo].[GetLocationsByStreet]
@Street nvarchar
AS
SELECT * FROM [dbo].[Locations]
WHERE [dbo].[Locations].Street=@Street
