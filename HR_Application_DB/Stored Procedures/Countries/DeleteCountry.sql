CREATE PROCEDURE [HRAppDB].[DeleteCountry]
	@ID int
AS
	delete from [HRAppDB].[Countries]
	where [HRAppDB].[Countries].ID = @ID
