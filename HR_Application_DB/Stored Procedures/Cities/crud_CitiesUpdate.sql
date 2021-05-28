CREATE PROCEDURE [dbo].[crud_CitiesUpdate]
	@ID int,
	@Name nvarchar(255),
	@CountryID int
AS
UPDATE [dbo].[Cities]
SET  [dbo].[Cities].[Name] = @Name,
     [dbo].[Cities].[CountryID] = @CountryID
WHERE  [dbo].[Cities].[ID] = @ID