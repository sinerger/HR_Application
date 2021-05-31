CREATE PROCEDURE [HRAppDB].[GetCityByID]
	@ID int
AS
	SELECT [HRAppDB].[Cities].[ID], [HRAppDB].[Cities].[Name], [HRAppDB].[Cities].[CountryID]
	FROM [HRAppDB].[Cities]
	WHERE [HRAppDB].[Cities].[ID] = @ID