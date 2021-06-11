CREATE PROCEDURE [HRAppDB].[GetCompaniesByName]
	@Name nvarchar (255)
AS
	select * from  [HRAppDB].[Companies]
	where [HRAppDB].[Companies].Title = @Name