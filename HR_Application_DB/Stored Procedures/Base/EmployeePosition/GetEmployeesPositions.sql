CREATE PROCEDURE [HRAppDB].[GetEmployeesPositions]
AS
SELECT 
 [HRAppDB].[Positions_Employees].ID,
  [HRAppDB].[Positions_Employees].EmployeeID,
   [HRAppDB].[Positions_Employees].PositionID,
    [HRAppDB].[Positions_Employees].HiredDate,
     [HRAppDB].[Positions_Employees].FiredDate,
      [HRAppDB].[Positions_Employees].IsActual,
       [HRAppDB].[Positions_Employees].LevelPositionID
FROM [HRAppDB].[Positions_Employees]