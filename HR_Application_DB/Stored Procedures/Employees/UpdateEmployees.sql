CREATE PROCEDURE [dbo].[UpdateEmployees]
	@ID int,
	@Photo nvarchar(255),
	@FirstName nvarchar(255),
	@LastName nvarchar(255),
	@RegistationDate datetime,
	@StatusID int,
	@LocationID int,
	@IsActual bit
AS
UPDATE [dbo].[Employees]
SET	   [dbo].[Employees].[Photo] = @Photo,
	   [dbo].[Employees].[FirstName] = @FirstName,
	   [dbo].[Employees].[LastName] = @LastName,
	   [dbo].[Employees].[RegistationDate] = @RegistationDate,
	   [dbo].[Employees].[StatusID] = @StatusID,
	   [dbo].[Employees].[LocationID] = @LocationID,
	   [dbo].[Employees].[IsActual] = @IsActual
WHERE  [dbo].[Employees].[ID] = @ID