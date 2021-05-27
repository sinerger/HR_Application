CREATE PROCEDURE [dbo].[crud_ProjectsCreate]
	@Title nvarchar(255),
	@Description nvarchar(255),
	@DirectionID int
AS
INSERT INTO [dbo].[Projects] (
	   [dbo].[Projects].[Title],
	   [dbo].[Projects].[Description],
	   [dbo].[Projects].[DirectionID]
	   )
	   VALUES (
       @Title,
	   @Description,
	   @DirectionID
	   )
