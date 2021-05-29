CREATE PROCEDURE [HRAppDB].[DeleteDirection]
	@ID int 
AS
	Delete from [HRAppDB].[Directions]
	where [HRAppDB].[Directions].ID = @ID