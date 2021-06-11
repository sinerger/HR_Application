CREATE PROCEDURE [HRAppDB].[UpdateCity]
	@ID int,
	@Name nvarchar (255),
	@CountryID int
AS
UPDATE [HRAppDB].[Cities]
SET  [HRAppDB].[Cities].[Name] = @Name,
     [HRAppDB].[Cities].[CountryID] = @CountryID
WHERE  [HRAppDB].[Cities].[ID] = @ID