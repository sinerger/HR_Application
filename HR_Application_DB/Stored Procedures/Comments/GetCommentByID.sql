CREATE PROCEDURE [dbo].[GetCommentByID]
	@ID int 
AS
	select * from [dbo].[Comments]
	where [dbo].[Comments].ID = @ID
