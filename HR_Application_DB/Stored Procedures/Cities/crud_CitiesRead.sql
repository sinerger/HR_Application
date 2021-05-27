CREATE PROCEDURE [dbo].[crud_CitiesRead]
AS
	SELECT [dbo].[Cities].[ID], [dbo].[Cities].[Name], [dbo].[Cities].[CountryID]
	FROM [dbo].[Cities]