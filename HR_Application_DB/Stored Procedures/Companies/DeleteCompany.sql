CREATE PROCEDURE [HRAppDB].[DeleteCompany]
	@ID int
AS

delete from [HRAppDB].[Companies]
where [HRAppDB].[Companies].ID = @ID
	