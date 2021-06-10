CREATE PROCEDURE [HRAppDB].[CreateProjects]
	@Title nvarchar,
	@Description nvarchar,
	@DirectionID int
AS
INSERT INTO [HRAppDB].[Projects]
	   VALUES (
       @Title,
	   @Description,
	   @DirectionID
	   )
