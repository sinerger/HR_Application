CREATE PROCEDURE [HRAppDB].[GetPositionByTitle]
	@Title nvarchar (255)
AS
	SELECT * FROM [HRAppDB].[Positions]
	WHERE [HRAppDB].[Positions].[Title] = @Title
