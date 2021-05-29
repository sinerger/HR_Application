CREATE PROCEDURE [HRAppDB].[GetCommentsByEmployeeID]
	@EmployeeID int
AS
	select * from [HRAppDB].[Comments]
	where [HRAppDB].[Comments].EmployeeID = @EmployeeID
