CREATE PROCEDURE [HRAppDB].[CreateEmployees]
	@Photo nvarchar (255),
	@FirstName nvarchar (255),
	@LastName nvarchar (255),
	@RegistrationDate nvarchar (255),
	@StatusID int,
	@LocationID int,
	@IsActual bit

AS
INSERT INTO [HRAppDB].[Employees] (
	   [HRAppDB].[Employees].[Photo],
	   [HRAppDB].[Employees].[FirstName],
	   [HRAppDB].[Employees].[LastName],
	   [HRAppDB].[Employees].[RegistrationDate],
	   [HRAppDB].[Employees].[StatusID],
	   [HRAppDB].[Employees].[LocationID],
	   [HRAppDB].[Employees].[IsActual]
	   )
	   OUTPUT INSERTED.[ID]
	   VALUES (
       @Photo,
	   @FirstName,
	   @LastName,
	   @RegistrationDate,
	   @StatusID,
	   @LocationID,
	   @IsActual
	   )
