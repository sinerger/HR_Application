CREATE PROCEDURE [HRAppDB].[UpdateEmployeeProject]
@ID int,
@EmployeeID int, 
@ProjectID int,
@StartDate nvarchar (255),
@EndDate nvarchar (255),
@IsActual bit
AS
UPDATE[HRAppDB].[Employees_Projects]
SET [HRAppDB].[Employees_Projects].EmployeeID=@EmployeeID,
[HRAppDB].[Employees_Projects].ProjectID=@ProjectID,
[HRAppDB].[Employees_Projects].StartDate=@StartDate,
[HRAppDB].[Employees_Projects].EndDate=@EndDate,
[HRAppDB].[Employees_Projects].IsActual=@IsActual
WHERE [HRAppDB].[Employees_Projects].ID=@ID
