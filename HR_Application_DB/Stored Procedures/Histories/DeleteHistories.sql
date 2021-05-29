CREATE PROCEDURE [HRAppDB].[DeleteHistories]
@ID int
AS
DELETE
FROM [HRAppDB].[Histories]
WHERE [HRAppDB].[Histories].ID=@ID