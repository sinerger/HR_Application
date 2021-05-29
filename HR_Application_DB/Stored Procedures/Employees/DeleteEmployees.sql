CREATE PROCEDURE [HRAppDB].[DeleteEmployees]
@ID int
AS
DELETE
FROM [HRAppDB].[Employees]
WHERE [HRAppDB].[Employees].[ID]=@ID
