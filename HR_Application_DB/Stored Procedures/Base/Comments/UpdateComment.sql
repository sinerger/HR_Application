CREATE PROCEDURE [HRAppDB].[UpdateComment]
	@ID int,
	@EmployeeID int,
	@Information nvarchar (255),
	@Date nvarchar (255)
AS
	Update [HRAppDB].[Comments]
	SET [HRAppDB].[Comments].EmployeeID = @EmployeeID,
		[HRAppDB].[Comments].Information = @Information,
		[HRAppDB].[Comments].[Date] = @Date

		Where [HRAppDB].[Comments].ID = @ID
