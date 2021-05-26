CREATE PROCEDURE [dbo].[GetCityByID]
	@ID int

AS

	select * from [dbo].[Cities]
	where [dbo].[Cities].ID = @ID