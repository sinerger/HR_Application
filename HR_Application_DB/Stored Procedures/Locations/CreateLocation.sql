CREATE PROCEDURE [dbo].[CreateLocation]
	@CityID int,
	@Street nvarchar,
	@HouseNumber int,
	@Block nvarchar,
	@ApartmentNumber int,
	@PostIndex int
AS
INSERT INTO [dbo].[Locations]
	VALUES (
		@CityID,
		@Street,
		@HouseNumber,
		@Block,
		@ApartmentNumber,
		@PostIndex
		)