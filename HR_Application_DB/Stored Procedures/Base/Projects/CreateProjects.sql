CREATE PROCEDURE [HRAppDB].[CreateProjects]
	@Title nvarchar (255),
	@Description nvarchar (255),
	@DirectionID int
AS
INSERT INTO [HRAppDB].[Projects]
	   VALUES (
       @Title,
	   @Description,
	   @DirectionID
	   )
