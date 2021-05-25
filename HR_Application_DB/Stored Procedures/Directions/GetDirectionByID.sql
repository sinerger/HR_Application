CREATE PROCEDURE [dbo].[GetDirectionByID]
	@ID int
AS
	SELECT * from [dbo].[Directions]
	WHERE [dbo].[Directions].ID=@ID