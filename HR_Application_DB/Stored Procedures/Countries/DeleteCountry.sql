CREATE PROCEDURE [dbo].[DeleteCountry]
	@ID int
AS
	delete from [dbo].[Countries]
	where [dbo].[Countries].ID = @ID
