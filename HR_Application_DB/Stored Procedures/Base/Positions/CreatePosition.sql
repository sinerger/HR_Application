CREATE PROCEDURE [HRAppDB].[CreatePosition]
	   @Title nvarchar,
	   @Description nvarchar
AS
INSERT INTO [HRAppDB].[Positions]  (
	   [HRAppDB].[Positions].[Title],
	   [HRAppDB].[Positions].[Description]
	   )
    VALUES (
	   @Title,
	   @Description
	   )