CREATE PROCEDURE [HRAppDB].[UpdateProjects]
	@ID int,
	@Title nvarchar(255),
	@Description nvarchar(255),
	@DirectionID int
AS
	UPDATE [HRAppDB].[Projects]
	SET [HRAppDB].[Projects].[Title] = @Title,
		[HRAppDB].[Projects].[Description] = @Description,
		[HRAppDB].[Projects].[DirectionID] = @DirectionID
	WHERE [HRAppDB].[Projects].[ID] = @ID