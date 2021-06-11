CREATE PROCEDURE [dbo].[DeleteEmployeeSkill]
@ID int
AS
DELETE
FROM [HRAppDB].[Employees_Skills]
WHERE [HRAppDB].[Employees_Skills].[ID]=@ID