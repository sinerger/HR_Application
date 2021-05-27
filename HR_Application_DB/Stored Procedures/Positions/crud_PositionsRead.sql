CREATE PROC [dbo].[crud_PositionsRead]
    @ID int
AS 
    SELECT [dbo].[Positions].[ID],
    [dbo].[Positions].[Title],
    [dbo].[Positions].[Description]
    FROM   [dbo].[Positions]
    WHERE  [dbo].[Positions].[ID] = @ID 
