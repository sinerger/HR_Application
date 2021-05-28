﻿CREATE PROCEDURE [dbo].[GetAdress]
AS
	SELECT Coun.[ID], Coun.[Name],
	Cit.[ID], Cit.[Name],
	Loc.[ID], Loc.[Street], Loc.[HouseNumber], Loc.[Block], Loc.[ApartmentNumber], Loc.[PostIndex]
	FROM [dbo].[Countries] as Coun
	INNER JOIN [dbo].[Cities] as Cit ON Coun.ID = Cit.CountryID
	INNER JOIN [dbo].[Locations] as Loc ON Cit.ID = Loc.CityID
