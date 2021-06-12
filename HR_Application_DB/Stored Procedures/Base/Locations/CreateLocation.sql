CREATE PROCEDURE [HRAppDB].[CreateLocation]
	@CityID int,
	@Street nvarchar (255),
	@HouseNumber int,
	@Block nvarchar (255),
	@ApartmentNumber int,
	@PostIndex int
AS
INSERT INTO [HRAppDB].[Locations]
OUTPUT INSERTED.[ID]
	VALUES (
		@CityID,
		@Street,
		@HouseNumber,
		@Block,
		@ApartmentNumber,
		@PostIndex
		)