CREATE PROCEDURE [HRAppDB].[CreateComment]
	@EmployeeID int,
	@Information nvarchar,
	@Date nvarchar
AS
	insert into [HRAppDB].[Comments]
	values (@EmployeeID,
	@Information,
	@Date)
