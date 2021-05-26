CREATE PROCEDURE [dbo].[GetCompaniesByName]
	@Name nvarchar
AS
	select * from  [dbo].[Companies]
	where [dbo].[Companies].Title = @Name