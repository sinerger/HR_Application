CREATE PROCEDURE [HRAppDB].[GetHistoriesByUpdated]
@Updated nvarchar (255)
AS
	SELECT * FROM [HRAppDB].[Histories]
	WHERE [HRAppDB].[Histories].Updated=@Updated