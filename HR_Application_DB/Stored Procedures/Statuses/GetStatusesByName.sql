CREATE PROCEDURE [dbo].[GetStatusesByName]
@Name nvarchar
AS
SELECT * FROM [dbo].[Statuses]
WHERE [dbo].[Statuses].Name=@Name