CREATE PROCEDURE [HRAppDB].[GetProjects]
AS
	SELECT [HRAppDB].[Projects].[ID],
	[HRAppDB].[Projects].[Title],
	[HRAppDB].[Projects].[Description],
	[HRAppDB].[Projects].[DirectionID]
	FROM [HRAppDB].[Projects]
