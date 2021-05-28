CREATE PROCEDURE [dbo].[DeleteEmployees]
@ID int
AS
DELETE
FROM [dbo].[Employees]
WHERE [dbo].[Employees].[ID]=@ID
