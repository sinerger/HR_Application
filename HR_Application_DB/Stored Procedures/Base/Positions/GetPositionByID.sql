CREATE PROCEDURE [HRAppDB].[GetPositionByID]
	@ID int
AS
	SELECT * FROM [HRAppDB].[Positions]
	WHERE [HRAppDB].[Positions].[ID] = @ID
