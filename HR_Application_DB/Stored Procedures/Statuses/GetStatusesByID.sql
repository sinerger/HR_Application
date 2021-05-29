CREATE PROCEDURE [HRAppDB].[GetStatusesByID]
@ID int
AS
SELECT * FROM [HRAppDB].[Statuses]
WHERE [HRAppDB].[Statuses].ID=@ID
