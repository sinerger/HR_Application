CREATE PROC [dbo].[UpdatePosition]
    @ID int,
    @Title nvarchar(255),
    @Description nvarchar(255)
AS
UPDATE [dbo].[Positions]
SET  [dbo].[Positions].[Title] = @Title,
     [dbo].[Positions].[Description] = @Description
WHERE  [dbo].[Positions].[ID] = @ID