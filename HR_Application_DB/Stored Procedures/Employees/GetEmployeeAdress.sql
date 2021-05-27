CREATE PROCEDURE [dbo].[GetEmployeeAdress]
AS
	SELECT 
	Empl.[ID] as EmplID, Empl.[Photo], Empl.[FirstName], Empl.[LastName], Empl.[RegistationDate], Empl.[IsActual],
	Stat.[ID] as StatID, Stat.[Name],
	Coun.[ID] as CounID, Coun.[Name],
	Cit.[ID] as CitID, Cit.[Name],
	Loc.[ID] as LocID, Loc.[Street], Loc.[HouseNumber], Loc.[Block], Loc.[ApartmentNumber], Loc.[PostIndex]
	FROM [dbo].[Countries] as Coun, [dbo].[Cities] as Cit, [dbo].[Locations] as Loc, [dbo].[Employees] as Empl, [dbo].[Statuses] as Stat
	WHERE (Cit.CountryID = Coun.ID) AND (Loc.CityID = Cit.ID) AND (Empl.LocationID = Loc.ID) AND (Empl.[StatusID] = Stat.[ID])