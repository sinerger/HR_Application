CREATE PROCEDURE [HRAppDB].[CreateLevelsPosition]
	@Title nvarchar,
	@Description nvarchar
AS
INSERT INTO [HRAppDB].[LevelsPosition]
	VALUES (
		@Title,
		@Description
		)
