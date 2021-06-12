CREATE PROCEDURE [HRAppDB].[CreateCity]
	@Name nvarchar (255),
	@CountryID int
AS
INSERT INTO [HRAppDB].[Cities] (
	   [HRAppDB].[Cities].[Name],
	   [HRAppDB].[Cities].[CountryID]
	   )
	   OUTPUT INSERTED.[ID]
	   VALUES (
	   @Name,
	   @CountryID
	   )
