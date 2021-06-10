CREATE PROCEDURE [HRAppDB].[CreateEmployeePosition]
	@EmployeeID int,
	@HiredDate nvarchar,
	@FiredDate nvarchar,
	@IsActual bit,
	@LevelPositionID int,
	@PositionID int

AS
INSERT INTO [HRAppDB].[Positions_Employees]
	VALUES (
	@EmployeeID,
	@HiredDate,
	@FiredDate,
	@IsActual,
	@LevelPositionID,
	@PositionID
	)