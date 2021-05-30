CREATE PROCEDURE [HRAppDB].[UpdateComment]
	@ID int,
	@EmployeeID int,
	@Information nvarchar,
	@Date dateTime
AS
	Update [HRAppDB].[Comments]
	SET [HRAppDB].[Comments].EmployeeID = @EmployeeID,
		[HRAppDB].[Comments].Information = @Information,
		[HRAppDB].[Comments].[Date] = @Date
