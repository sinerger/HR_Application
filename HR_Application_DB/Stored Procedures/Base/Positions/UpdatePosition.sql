CREATE PROC [HRAppDB].[UpdatePosition]
    @ID int,
    @Title nvarchar,
    @Description nvarchar
AS
UPDATE [HRAppDB].[Positions]
SET  [HRAppDB].[Positions].[Title] = @Title,
     [HRAppDB].[Positions].[Description] = @Description
WHERE  [HRAppDB].[Positions].[ID] = @ID