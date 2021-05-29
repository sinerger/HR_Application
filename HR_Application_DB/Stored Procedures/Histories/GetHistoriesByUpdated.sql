CREATE PROCEDURE [HRAppDB].[GetHistoriesByUpdated]
@Updated datetime
AS
	SELECT * FROM [HRAppDB].[Histories]
	WHERE [HRAppDB].[Histories].Updated=@Updated