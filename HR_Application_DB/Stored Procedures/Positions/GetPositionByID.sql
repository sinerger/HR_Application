CREATE PROCEDURE [dbo].[GetPositionByID]
	@ID int
AS
	SELECT * FROM [dbo].[Positions]
	WHERE [dbo].[Positions].[ID] = @ID
