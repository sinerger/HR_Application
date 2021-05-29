CREATE PROC [HRAppDB].[DeletePosition]
    @ID int
AS 
DELETE
FROM   [HRAppDB].[Positions]
WHERE  [HRAppDB].[Positions].[ID] = @ID