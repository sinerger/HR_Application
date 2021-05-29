CREATE PROCEDURE [HRAppDB].[GetStatusesByName]
@Name nvarchar
AS
SELECT * FROM [HRAppDB].[Statuses]
WHERE [HRAppDB].[Statuses].Name=@Name