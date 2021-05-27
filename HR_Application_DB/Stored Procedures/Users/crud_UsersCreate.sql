CREATE PROCEDURE [dbo].[crud_UsersCreate]
	@FisrtName nvarchar,
	@LastName nvarchar,
	@CompanyID int,
	@Email nvarchar,
	@Password nvarchar,
	@IsActual bit
AS
	INSERT INTO [dbo].[Users](
		[dbo].[Users].[FisrtName],
		[dbo].[Users].[LastName],
		[dbo].[Users].[CompanyID],
		[dbo].[Users].[Email],
		[dbo].[Users].[Passvord],
		[dbo].[Users].[IsActual]
		)
	VALUES (
		@FisrtName,
		@LastName,
		@CompanyID,
		@Email,
		@Password,
		@IsActual
	)
