CREATE PROCEDURE [HRAppDB].[GetCountryByID]
	@ID int 
AS
	select * from [HRAppDB].[Countries]
	where [HRAppDB].[Countries].ID = @ID
