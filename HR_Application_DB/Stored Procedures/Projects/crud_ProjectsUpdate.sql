CREATE PROCEDURE [dbo].[crud_ProjectsUpdate]
	@ID int,
	@Title nvarchar(255),
	@Description nvarchar(255),
	@DirectionID int
AS
	UPDATE [dbo].[Projects]
	SET [dbo].[Projects].[Title] = @Title,
		[dbo].[Projects].[Description] = @Description,
		[dbo].[Projects].[DirectionID] = @DirectionID
	WHERE [dbo].[Projects].[ID] = @ID