CREATE PROCEDURE [dbo].[GetProjects]
AS
	SELECT [dbo].[Projects].[ID],
	[dbo].[Projects].[Title],
	[dbo].[Projects].[Description],
	[dbo].[Projects].[DirectionID]
	FROM [dbo].[Projects]
