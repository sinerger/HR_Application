CREATE PROCEDURE [dbo].[DeleteDirection]
	@ID int 
AS
	Delete from [dbo].[Directions]
	where [dbo].[Directions].ID = @ID