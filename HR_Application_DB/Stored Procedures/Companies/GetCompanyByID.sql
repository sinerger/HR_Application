CREATE PROCEDURE [dbo].[GetCompanyByID]
	@ID int
AS
	select * from [dbo].[Companies]
	where [dbo].[Companies].ID = @ID
