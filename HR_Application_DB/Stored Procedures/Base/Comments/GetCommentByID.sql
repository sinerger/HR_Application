CREATE PROCEDURE [HRAppDB].[GetCommentByID]
	@ID int 
AS
	select * from [HRAppDB].[Comments]
	where [HRAppDB].[Comments].ID = @ID
