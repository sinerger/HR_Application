CREATE PROCEDURE [HRAppDB].[UpdateUsers]
	@ID int,
	@FisrtName nvarchar,
	@LastName nvarchar,
	@CompanyID int,
	@Email nvarchar,
	@Password nvarchar,
	@IsActual bit
AS
	UPDATE [HRAppDB].[Users]
	SET [HRAppDB].[Users].[FisrtName] = @FisrtName,
		[HRAppDB].[Users].[LastName] = @LastName,
		[HRAppDB].[Users].[CompanyID] = @CompanyID,
		[HRAppDB].[Users].[Email] = @Email,
		[HRAppDB].[Users].[Passvord] = @Password,
		[HRAppDB].[Users].[IsActual] = @IsActual
	WHERE [HRAppDB].[Users].[ID] = @ID

