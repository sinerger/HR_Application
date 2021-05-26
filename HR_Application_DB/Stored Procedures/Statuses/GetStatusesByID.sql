CREATE PROCEDURE [dbo].[GetStatusesByID]
@ID int
AS
SELECT * FROM [dbo].[Statuses]
WHERE [dbo].[Statuses].ID=@ID
