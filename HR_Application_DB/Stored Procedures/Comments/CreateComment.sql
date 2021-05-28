CREATE PROCEDURE [dbo].[CreateComment]
	@EmployeeID int,
	@Information nvarchar,
	@Date dateTime
AS
	insert into [dbo].[Comments]
	values (@EmployeeID,
	@Information,
	@Date)
