CREATE PROCEDURE [dbo].[UpdateLocation]
	@ID int,
	@CityID int,
	@Street nvarchar,
	@HouseNumber int,
	@Block nvarchar,
	@ApartmentNumber int,
	@PostIndex int
AS
UPDATE [dbo].[Locations]
SET [dbo].[Locations].[CityID] = @CityID,
	[dbo].[Locations].[Street] = @Street,
	[dbo].[Locations].[HouseNumber] = @HouseNumber,
	[dbo].[Locations].[Block] = @Block,
	[dbo].[Locations].[ApartmentNumber] = @ApartmentNumber,
	[dbo].[Locations].[PostIndex] = @PostIndex
WHERE [dbo].[Locations].[ID] = @ID
