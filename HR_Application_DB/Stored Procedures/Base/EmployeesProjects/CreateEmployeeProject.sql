CREATE PROCEDURE [HRAppDB].[CreateEmployeeProject]
@EmployeeID int, 
@ProjectID int,
@StartDate nvarchar (255),
@EndDate nvarchar (255),
@IsActual bit
AS
INSERT INTO [HRAppDB].[Employees_Projects](
[HRAppDB].[Employees_Projects].EmployeeID,
[HRAppDB].[Employees_Projects].ProjectID,
[HRAppDB].[Employees_Projects].StartDate,
[HRAppDB].[Employees_Projects].EndDate,
[HRAppDB].[Employees_Projects].IsActual
)
VALUES(
@EmployeeID, 
@ProjectID,
@StartDate,
@EndDate,
@IsActual
)