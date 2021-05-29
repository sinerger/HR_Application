CREATE PROCEDURE [HRAppDB].[CreateComment]
	@EmployeeID int,
	@Information nvarchar,
	@Date dateTime
AS
	insert into [HRAppDB].[Comments]
	values (@EmployeeID,
	@Information,
	@Date)
