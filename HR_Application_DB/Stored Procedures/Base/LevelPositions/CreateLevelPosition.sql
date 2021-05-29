CREATE PROCEDURE [dbo].[CreateLevelPosition]
	@Title nvarchar,
	@Description nvarchar
AS
INSERT INTO [dbo].[LevelPositions]
	VALUES (
		@Title,
		@Description
		)
