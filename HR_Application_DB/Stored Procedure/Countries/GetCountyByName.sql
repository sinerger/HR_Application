CREATE PROCEDURE [dbo].[GetCountyByName]
	@Name nvarchar
AS
	select * from [dbo].[Countries]
	where [dbo].[Countries].[Name] = @Name