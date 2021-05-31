CREATE PROCEDURE [HRAppDB].[CreateLevelPosition]
	@Title nvarchar,
	@Description nvarchar
AS
INSERT INTO [HRAppDB].[LevelPositions]
	VALUES (
		@Title,
		@Description
		)
