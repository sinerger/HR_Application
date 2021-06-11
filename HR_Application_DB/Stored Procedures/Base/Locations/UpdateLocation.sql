CREATE PROCEDURE [HRAppDB].[UpdateLocation]
	@ID int,
	@CityID int,
	@Street nvarchar (255),
	@HouseNumber int,
	@Block nvarchar (255),
	@ApartmentNumber int,
	@PostIndex int
AS
UPDATE [HRAppDB].[Locations]
SET [HRAppDB].[Locations].[CityID] = @CityID,
	[HRAppDB].[Locations].[Street] = @Street,
	[HRAppDB].[Locations].[HouseNumber] = @HouseNumber,
	[HRAppDB].[Locations].[Block] = @Block,
	[HRAppDB].[Locations].[ApartmentNumber] = @ApartmentNumber,
	[HRAppDB].[Locations].[PostIndex] = @PostIndex
WHERE [HRAppDB].[Locations].[ID] = @ID
