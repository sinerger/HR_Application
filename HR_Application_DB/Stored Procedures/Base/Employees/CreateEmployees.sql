﻿CREATE PROCEDURE [HRAppDB].[CreateEmployees]
	@Photo nvarchar(255),
	@FirstName nvarchar(255),
	@LastName nvarchar(255),
	@RegistationDate datetime,
	@StatusID int,
	@LocationID int,
	@IsActual bit

AS
INSERT INTO [HRAppDB].[Employees] (
	   [HRAppDB].[Employees].[Photo],
	   [HRAppDB].[Employees].[FirstName],
	   [HRAppDB].[Employees].[LastName],
	   [HRAppDB].[Employees].[RegistationDate],
	   [HRAppDB].[Employees].[StatusID],
	   [HRAppDB].[Employees].[LocationID],
	   [HRAppDB].[Employees].[IsActual]
	   )
	   VALUES (
       @Photo,
	   @FirstName,
	   @LastName,
	   @RegistationDate,
	   @StatusID,
	   @LocationID,
	   @IsActual
	   )
