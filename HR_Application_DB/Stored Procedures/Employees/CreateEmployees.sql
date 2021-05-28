CREATE PROCEDURE [dbo].[CreateEmployees]
	@Photo nvarchar(255),
	@FirstName nvarchar(255),
	@LastName nvarchar(255),
	@RegistationDate datetime,
	@StatusID int,
	@LocationID int,
	@IsActual bit

AS
INSERT INTO [dbo].[Employees] (
	   [dbo].[Employees].[Photo],
	   [dbo].[Employees].[FirstName],
	   [dbo].[Employees].[LastName],
	   [dbo].[Employees].[RegistationDate],
	   [dbo].[Employees].[StatusID],
	   [dbo].[Employees].[LocationID],
	   [dbo].[Employees].[IsActual]
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

