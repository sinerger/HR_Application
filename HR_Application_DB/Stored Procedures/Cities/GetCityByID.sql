CREATE PROCEDURE [dbo].[GetCityByID]
	@ID int
AS
	SELECT [dbo].[Cities].[ID], [dbo].[Cities].[Name], [dbo].[Cities].[CountryID]
	FROM [dbo].[Cities]
	WHERE [dbo].[Cities].[ID] = @ID