CREATE PROCEDURE [HRAppDB].[GetCompaniesByName]
	@Name nvarchar
AS
	select * from  [HRAppDB].[Companies]
	where [HRAppDB].[Companies].Title = @Name