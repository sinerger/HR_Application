CREATE PROCEDURE [dbo].[GetPositionByTitle]
	@Title nvarchar
AS
	SELECT * FROM [dbo].[Positions]
	WHERE [dbo].[Positions].[Title] = @Title
