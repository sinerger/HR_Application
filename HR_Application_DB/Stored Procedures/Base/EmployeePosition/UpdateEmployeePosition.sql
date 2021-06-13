CREATE PROCEDURE [HRAppDB].[UpdateEmployeePosition]
	@ID int,
	@EmployeeID int,
	@PositionID int,
	@HiredDate nvarchar (255),
	@FiredDate nvarchar (255),
	@LevelPositionID int
AS
UPDATE [HRAppDB].[Positions_Employees]
SET 
	[HRAppDB].[Positions_Employees].[EmployeeID] = @EmployeeID,
	[HRAppDB].[Positions_Employees].[PositionID] = @PositionID,
	[HRAppDB].[Positions_Employees].[HiredDate] = @HiredDate,
	[HRAppDB].[Positions_Employees].[FiredDate] = @FiredDate,
	[HRAppDB].[Positions_Employees].[LevelPositionID] = @LevelPositionID
	where [HRAppDB].[Positions_Employees].ID = @ID
