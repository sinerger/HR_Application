CREATE PROCEDURE [HRAppDB].[CreateCity]
	@Name nvarchar,
	@CountryID int
AS
INSERT INTO [HRAppDB].[Cities] (
	   [HRAppDB].[Cities].[Name],
	   [HRAppDB].[Cities].[CountryID]
	   )
    VALUES (
	   @Name,
	   @CountryID
	   )
