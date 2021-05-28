CREATE PROC [dbo].[DeletePosition]
    @ID int
AS 
DELETE
FROM   [dbo].[Positions]
WHERE  [dbo].[Positions].[ID] = @ID