CREATE PROCEDURE [HRAppDB].[UpdateEmployeePosition]
	@ID int,
	@EmployeeID int,
	@HiredDate nvarchar (255),
	@FiredDate nvarchar (255),
	@LevelPositionID int,
	@PositionID int
AS
UPDATE [HRAppDB].[Positions_Employees]
SET 
	[HRAppDB].[Positions_Employees].[EmployeeID] = @EmployeeID,
	[HRAppDB].[Positions_Employees].[HiredDate] = @HiredDate,
	[HRAppDB].[Positions_Employees].[FiredDate] = @FiredDate,
	[HRAppDB].[Positions_Employees].[LevelPositionID] = @LevelPositionID,
	[HRAppDB].[Positions_Employees].[PositionID] = @PositionID
