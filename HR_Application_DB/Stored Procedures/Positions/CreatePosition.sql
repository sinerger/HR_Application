﻿CREATE PROCEDURE [HRAppDB].[CreatePosition]
	   @Title nvarchar(255),
	   @Description nvarchar(255)
AS
INSERT INTO [HRAppDB].[Positions]  (
	   [HRAppDB].[Positions].[Title],
	   [HRAppDB].[Positions].[Description]
	   )
    VALUES (
	   @Title,
	   @Description
	   )