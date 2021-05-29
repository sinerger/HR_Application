CREATE PROCEDURE [HRAppDB].[CreateProjects]
	@Title nvarchar(255),
	@Description nvarchar(255),
	@DirectionID int
AS
INSERT INTO [HRAppDB].[Projects] (
	   [HRAppDB].[Projects].[Title],
	   [HRAppDB].[Projects].[Description],
	   [HRAppDB].[Projects].[DirectionID]
	   )
	   VALUES (
       @Title,
	   @Description,
	   @DirectionID
	   )
