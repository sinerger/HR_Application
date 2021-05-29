CREATE PROCEDURE [HRAppDB].[GetCountyByName]
	@Name nvarchar
AS
	select * from [HRAppDB].[Countries]
	where [HRAppDB].[Countries].[Name] = @Name