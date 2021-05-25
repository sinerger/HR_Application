CREATE PROCEDURE [dbo].[GetLevelPositionsByTitle]
@Title nvarchar
AS
	SELECT *FROM [dbo].[LevelPositions]
	WHERE [dbo].[LevelPositions].Title=@Title

