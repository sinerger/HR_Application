CREATE PROCEDURE [HRAppDB].[CreateLocation]
	@CityID int,
	@Street nvarchar (255) null,
	@HouseNumber int null,
	@Block nvarchar (255) null,
	@ApartmentNumber int null,
	@PostIndex int null
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