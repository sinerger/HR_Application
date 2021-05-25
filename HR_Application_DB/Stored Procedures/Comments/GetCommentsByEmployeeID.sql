CREATE PROCEDURE [dbo].[GetCommentsByEmployeeID]
	@EmployeeID int
AS
	select * from [dbo].[Comments]
	where [dbo].[Comments].EmployeeID = @EmployeeID
