CREATE PROCEDURE [HRAppDB].[UpdateEmployees]
	@ID int,
	@Photo nvarchar (255),
	@FirstName nvarchar (255),
	@LastName nvarchar (255),
	@RegistrationDate nvarchar (255),
	@StatusID int,
	@LocationID int,
	@IsActual bit
AS
UPDATE [HRAppDB].[Employees]
SET	   [HRAppDB].[Employees].[Photo] = @Photo,
	   [HRAppDB].[Employees].[FirstName] = @FirstName,
	   [HRAppDB].[Employees].[LastName] = @LastName,
	   [HRAppDB].[Employees].[RegistrationDate] = @RegistrationDate,
	   [HRAppDB].[Employees].[StatusID] = @StatusID,
	   [HRAppDB].[Employees].[LocationID] = @LocationID,
	   [HRAppDB].[Employees].[IsActual] = @IsActual
WHERE  [HRAppDB].[Employees].[ID] = @ID