CREATE PROCEDURE [dbo].[CreateLocation]
	@CityID int,
	@Street nvarchar,
	@HouseNumber int,
	@Block nvarchar,
	@ApartmentNumber int,
	@PostIndex int
AS
INSERT INTO [dbo].[Locations] (
		[dbo].[Locations].[CityID],
		[dbo].[Locations].[Street],
		[dbo].[Locations].[HouseNumber],
		[dbo].[Locations].[Block],
		[dbo].[Locations].[ApartmentNumber],
		[dbo].[Locations].[PostIndex]
		)
	VALUES (
		@CityID,
		@Street,
		@HouseNumber,
		@Block,
		@ApartmentNumber,
		@PostIndex
		)