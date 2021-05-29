CREATE PROCEDURE [HRAppDB].[GetDirectionByID]
	@ID int
AS
	SELECT * from [HRAppDB].[Directions]
	WHERE [HRAppDB].[Directions].ID=@ID