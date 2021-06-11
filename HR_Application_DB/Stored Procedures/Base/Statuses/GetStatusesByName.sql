CREATE PROCEDURE [HRAppDB].[GetStatusesByName]
@Name nvarchar (255)
AS
SELECT * FROM [HRAppDB].[Statuses]
WHERE [HRAppDB].[Statuses].Name=@Name