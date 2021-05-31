CREATE PROCEDURE [HRAppDB].[GetCompanyByID]
	@ID int
AS
	select * from [HRAppDB].[Companies]
	where [HRAppDB].[Companies].ID = @ID
