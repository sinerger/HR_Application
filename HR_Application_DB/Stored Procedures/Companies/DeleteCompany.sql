CREATE PROCEDURE [dbo].[DeleteCompany]
	@ID int
AS

delete from [dbo].[Companies]
where [dbo].[Companies].ID = @ID
	