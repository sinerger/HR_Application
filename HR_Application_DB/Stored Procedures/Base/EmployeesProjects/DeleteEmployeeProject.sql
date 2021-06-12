CREATE PROCEDURE [HRAppDB].[DeleteEmployeeProject]
@ID int
AS
DELETE
FROM [HRAppDB].[Employees_Projects]
WHERE [HRAppDB].[Employees_Projects].ID=@ID
