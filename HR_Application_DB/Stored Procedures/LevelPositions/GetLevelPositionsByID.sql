CREATE PROCEDURE [dbo].[GetLevelPositionsByID]
@ID int
AS
	SELECT * FROM [dbo].[LevelPositions]
	WHERE [dbo].[LevelPositions].ID=@ID 