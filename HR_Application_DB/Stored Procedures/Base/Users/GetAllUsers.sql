CREATE PROCEDURE [HRAppDB].[GetAllUsers]
	AS
	SELECT        
		[HRAppDB].Users.ID,
		[HRAppDB].Users.FisrtName,
		[HRAppDB].Users.LastName,
		[HRAppDB].Users.Email, 
		[HRAppDB].Users.[Password],
		[HRAppDB].Users.IsActual,
		[HRAppDB].Companies.ID,
		[HRAppDB].Companies.Title, 
		[HRAppDB].Companies.[Description], 
		[HRAppDB].Companies.IsActual, 
		[HRAppDB].Locations.ID, 
		[HRAppDB].Locations.Street, 
		[HRAppDB].Locations.HouseNumber, 
		[HRAppDB].Locations.[Block], 
		[HRAppDB].Locations.ApartmentNumber, 
		[HRAppDB].Locations.PostIndex, 
		[HRAppDB].Cities.ID , 
		[HRAppDB].Cities.[Name], 
		[HRAppDB].Countries.ID , 
		[HRAppDB].Countries.[Name] 

	FROM [HRAppDB].Users 
	INNER JOIN [HRAppDB].Companies 
	ON 
	[HRAppDB].Users.ID = [HRAppDB].Companies.ID 
	INNER JOIN [HRAppDB].Locations 
	ON 
	[HRAppDB].Users.ID = [HRAppDB].Locations.ID 
	INNER JOIN [HRAppDB].Countries 
	ON 
	[HRAppDB].Users.ID = [HRAppDB].Countries.ID
	INNER JOIN [HRAppDB].Cities 
	ON 
	[HRAppDB].Users.ID = [HRAppDB].Cities.ID
