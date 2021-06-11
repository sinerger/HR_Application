CREATE PROCEDURE [HRAppDB].[CreateLevelPosition]
	@Title nvarchar,
	@Description nvarchar
AS
INSERT INTO [HRAppDB].[LevelPosition]
	VALUES (
		@Title,
		@Description
		)
