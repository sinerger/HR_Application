CREATE PROCEDURE [dbo].[crud_ProjectsRead]
AS
	SELECT [dbo].[Projects].[ID],
	[dbo].[Projects].[Title],
	[dbo].[Projects].[Description],
	[dbo].[Projects].[DirectionID]
	FROM [dbo].[Projects]
