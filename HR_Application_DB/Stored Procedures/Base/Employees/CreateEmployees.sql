CREATE PROCEDURE [HRAppDB].[CreateEmployees]
	@Photo nvarchar,
	@FirstName nvarchar,
	@LastName nvarchar,
	@RegistationDate nvarchar,
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

