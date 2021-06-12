CREATE PROCEDURE [HRAppDB].[CreateComment]
	@EmployeeID int,
	@Information nvarchar (255),
	@Date nvarchar (255)
AS
	INSERT INTO [HRAppDB].[Comments]
	OUTPUT INSERTED.[ID]
	VALUES (
	@EmployeeID,
	@Information,
	@Date
	)
