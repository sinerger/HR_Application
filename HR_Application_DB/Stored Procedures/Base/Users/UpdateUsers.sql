CREATE PROCEDURE [HRAppDB].[UpdateUsers]
	@ID int,
	@FirstName nvarchar (255),
	@LastName nvarchar (255),
	@CompanyID int,
	@Email nvarchar (255),
	@Password nvarchar (255),
	@IsActual bit
AS
	UPDATE [HRAppDB].[Users]
	SET [HRAppDB].[Users].[FirstName] = @FirstName,
		[HRAppDB].[Users].[LastName] = @LastName,
		[HRAppDB].[Users].[CompanyID] = @CompanyID,
		[HRAppDB].[Users].[Email] = @Email,
		[HRAppDB].[Users].[Password] = @Password,
		[HRAppDB].[Users].[IsActual] = @IsActual
	WHERE [HRAppDB].[Users].[ID] = @ID

