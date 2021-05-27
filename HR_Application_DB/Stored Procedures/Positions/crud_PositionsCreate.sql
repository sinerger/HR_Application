CREATE PROCEDURE [dbo].[crud_PositionsCreate]
	   @Title nvarchar(255),
	   @Description nvarchar(255)
AS
INSERT INTO [dbo].[Positions]  (
	   [dbo].[Positions].[Title],
	   [dbo].[Positions].[Description]
	   )
    VALUES (
	   @Title,
	   @Description
	   )