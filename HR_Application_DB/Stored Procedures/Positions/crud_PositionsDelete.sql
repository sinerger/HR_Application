CREATE PROC [dbo].[crud_PositionsDelete]
    @ID int
AS 
DELETE
FROM   [dbo].[Positions]
WHERE  [dbo].[Positions].[ID] = @ID