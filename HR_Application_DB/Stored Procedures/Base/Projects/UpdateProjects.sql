CREATE PROCEDURE [HRAppDB].[UpdateProjects]
	@ID int,
	@Title nvarchar,
	@Description nvarchar,
	@DirectionID int
AS
UPDATE [HRAppDB].[Projects]
SET [HRAppDB].[Projects].[Title] = @Title,
	[HRAppDB].[Projects].[Description] = @Description,
	[HRAppDB].[Projects].[DirectionID] = @DirectionID
WHERE [HRAppDB].[Projects].[ID] = @ID