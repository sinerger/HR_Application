CREATE PROCEDURE [HRAppDB].[GetCountyByName]
	@Name nvarchar (255)
AS
	select * from [HRAppDB].[Countries]
	where [HRAppDB].[Countries].[Name] = @Name