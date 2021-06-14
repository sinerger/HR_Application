CREATE PROCEDURE [HRAppDB].[UpdateLocation]
	@ID int,
	@CityID int,
	@Street nvarchar (255) null,
	@HouseNumber int null,
	@Block nvarchar (255) null,
	@ApartmentNumber int null,
	@PostIndex int null
AS
UPDATE [HRAppDB].[Locations]
SET [HRAppDB].[Locations].[CityID] = @CityID,
	[HRAppDB].[Locations].[Street] = @Street,
	[HRAppDB].[Locations].[HouseNumber] = @HouseNumber,
	[HRAppDB].[Locations].[Block] = @Block,
	[HRAppDB].[Locations].[ApartmentNumber] = @ApartmentNumber,
	[HRAppDB].[Locations].[PostIndex] = @PostIndex
WHERE [HRAppDB].[Locations].[ID] = @ID
