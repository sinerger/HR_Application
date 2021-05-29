CREATE PROCEDURE [HRAppDB].[GetAdress]
AS
	SELECT Coun.[ID], Coun.[Name],
	Cit.[ID], Cit.[Name],
	Loc.[ID], Loc.[Street], Loc.[HouseNumber], Loc.[Block], Loc.[ApartmentNumber], Loc.[PostIndex]
	FROM [HRAppDB].[Countries] as Coun
	INNER JOIN [HRAppDB].[Cities] as Cit ON Coun.ID = Cit.CountryID
	INNER JOIN [HRAppDB].[Locations] as Loc ON Cit.ID = Loc.CityID
