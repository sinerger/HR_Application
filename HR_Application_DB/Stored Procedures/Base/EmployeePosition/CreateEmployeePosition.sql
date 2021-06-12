CREATE PROCEDURE [HRAppDB].[CreateEmployeePosition]
	@EmployeeID int,
	@HiredDate nvarchar (255),
	@FiredDate nvarchar (255),
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