CREATE PROCEDURE [dbo].[UpdateComment]
	@ID int,
	@EmployeeID int,
	@Information nvarchar,
	@Date dateTime
AS
	Update [dbo].[Comments]
	SET [dbo].[Comments].EmployeeID = @EmployeeID,
		[dbo].[Comments].Information = @Information,
		[dbo].[Comments].[Date] = @Date
