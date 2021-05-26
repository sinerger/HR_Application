CREATE PROCEDURE [dbo].[GetCountryByID]
	@ID int 
AS
	select * from [dbo].[Countries]
	where [dbo].[Countries].ID = @ID
