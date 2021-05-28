CREATE PROCEDURE [dbo].[DeleteHistories]
@ID int
AS
DELETE
FROM [dbo].[Histories]
WHERE [dbo].[Histories].ID=@ID