CREATE PROCEDURE [HRAppDB].[CreateProjects]
	@Title nvarchar (255),
	@Description nvarchar (255) null,
	@DirectionID int
AS
INSERT INTO [HRAppDB].[Projects]
	   OUTPUT INSERTED.[ID]
	   VALUES (
       @Title,
	   @Description,
	   @DirectionID
	   )
