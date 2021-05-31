CREATE PROCEDURE [HRAppDB].[GetHistoriesByUpdated]
@Updated nvarchar
AS
	SELECT * FROM [HRAppDB].[Histories]
	WHERE [HRAppDB].[Histories].Updated=@Updated