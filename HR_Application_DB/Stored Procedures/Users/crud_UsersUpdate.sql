CREATE PROCEDURE [dbo].[crud_UsersUpdate]
	@ID int,
	@FisrtName nvarchar,
	@LastName nvarchar,
	@CompanyID int,
	@Email nvarchar,
	@Password nvarchar,
	@IsActual bit
AS
	UPDATE [dbo].[Users]
	SET [dbo].[Users].[FisrtName] = @FisrtName,
		[dbo].[Users].[LastName] = @LastName,
		[dbo].[Users].[CompanyID] = @CompanyID,
		[dbo].[Users].[Email] = @Email,
		[dbo].[Users].[Passvord] = @Password,
		[dbo].[Users].[IsActual] = @IsActual
	WHERE [dbo].[Users].[ID] = @ID

