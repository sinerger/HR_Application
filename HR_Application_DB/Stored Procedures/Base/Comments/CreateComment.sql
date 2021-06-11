CREATE PROCEDURE [HRAppDB].[CreateComment]
	@EmployeeID int,
	@Information nvarchar (255),
	@Date nvarchar (255)
AS
	insert into [HRAppDB].[Comments]
	values (@EmployeeID,
	@Information,
	@Date)
