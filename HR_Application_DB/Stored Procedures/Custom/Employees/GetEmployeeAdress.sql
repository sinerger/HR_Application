CREATE PROCEDURE [HRAppDB].[GetEmployeeAdress]
AS
	SELECT 
		Empl.[ID] as EmplID, 
		Empl.[Photo], 
		Empl.[FirstName], 
		Empl.[LastName], 
		Empl.[RegistationDate], 
		Empl.[IsActual],
		Stat.[ID] as StatID, 
		Stat.[Name],
		Coun.[ID] as CounID, 
		Coun.[Name],
		Cit.[ID] as CitID, 
		Cit.[Name],
		Loc.[ID] as LocID, 
		Loc.[Street], 
		Loc.[HouseNumber], 
		Loc.[Block], 
		Loc.[ApartmentNumber], 
		Loc.[PostIndex]
	FROM
		[HRAppDB].[Countries] as Coun, 
		[HRAppDB].[Cities] as Cit, 
		[HRAppDB].[Locations] as Loc, 
		[HRAppDB].[Employees] as Empl, 
		[HRAppDB].[Statuses] as Stat
	WHERE 
		(Cit.CountryID = Coun.ID) 
			AND 
		(Loc.CityID = Cit.ID) 
			AND 
		(Empl.LocationID = Loc.ID) 
			AND 
		(Empl.[StatusID] = Stat.[ID])