CREATE PROCEDURE [dbo].[crud_CitiesCreate]
	@Name nvarchar(255),
	@CountryID int
AS
INSERT INTO [dbo].[Cities] (
	   [dbo].[Cities].[Name],
	   [dbo].[Cities].[CountryID]
	   )
    VALUES (
	   @Name,
	   @CountryID
	   )
