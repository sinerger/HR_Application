CREATE PROCEDURE [HRAppDB].[GetEmployees]
AS
SELECT [HRAppDB].[Employees].*
FROM [HRAppDB].[Employees]
where [HRAppDB].[Employees].IsActual=1 