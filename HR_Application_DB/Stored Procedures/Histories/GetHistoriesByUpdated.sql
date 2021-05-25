CREATE PROCEDURE [dbo].[GetHistoriesByUpdated]
@Updated datetime
AS
	SELECT * FROM [dbo].[Histories]
	WHERE [dbo].[Histories].Updated=@Updated