CREATE PROC [HRAppDB].[UpdatePosition]
    @ID int,
    @Title nvarchar(255),
    @Description nvarchar(255)
AS
UPDATE [HRAppDB].[Positions]
SET  [HRAppDB].[Positions].[Title] = @Title,
     [HRAppDB].[Positions].[Description] = @Description
WHERE  [HRAppDB].[Positions].[ID] = @ID