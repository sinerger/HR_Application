CREATE PROCEDURE [HRAppDB].[GetPositionByTitle]
	@Title nvarchar
AS
	SELECT * FROM [HRAppDB].[Positions]
	WHERE [HRAppDB].[Positions].[Title] = @Title
