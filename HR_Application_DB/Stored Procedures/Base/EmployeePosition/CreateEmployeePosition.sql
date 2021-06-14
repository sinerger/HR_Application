CREATE PROCEDURE [HRAppDB].[CreateEmployeePosition]
	@EmployeeID int,
	@HiredDate nvarchar (255) null,
	@FiredDate nvarchar (255) null,
	@IsActual bit,
	@LevelPositionID int,
	@PositionID int

AS
INSERT INTO [HRAppDB].[Positions_Employees]
OUTPUT INSERTED.[ID]
	VALUES (
	@EmployeeID,
	@HiredDate,
	@FiredDate,
	@IsActual,
	@LevelPositionID,
	@PositionID
	)
	RETURN @@IDENTITY 