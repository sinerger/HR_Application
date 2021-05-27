CREATE PROCEDURE [dbo].[crud_CitiesDelete]
	@ID int
AS
	DELETE
	FROM [dbo].[Cities]
	WHERE [dbo].[Cities].[ID] = @ID