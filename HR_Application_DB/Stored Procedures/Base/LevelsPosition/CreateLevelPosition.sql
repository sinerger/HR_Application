CREATE PROCEDURE [HRAppDB].[CreateLevelPosition]
	@Title nvarchar (255),
	@Description nvarchar (255)
AS
INSERT INTO [HRAppDB].[LevelPositions]
	OUTPUT INSERTED.[ID]
	VALUES (
		@Title,
		@Description
		)
