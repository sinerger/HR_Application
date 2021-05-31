CREATE PROCEDURE [HRAppDB].[CreateProjects]
	@Title nvarchar,
	@Description nvarchar,
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
