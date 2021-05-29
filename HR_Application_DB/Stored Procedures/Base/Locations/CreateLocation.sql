CREATE PROCEDURE [HRAppDB].[CreateLocation]
	@CityID int,
	@Street nvarchar,
	@HouseNumber int,
	@Block nvarchar,
	@ApartmentNumber int,
	@PostIndex int
AS
INSERT INTO [HRAppDB].[Locations]
	VALUES (
		@CityID,
		@Street,
		@HouseNumber,
		@Block,
		@ApartmentNumber,
		@PostIndex
		)