CREATE PROCEDURE [HRAppDB].[CreateUsers]
	@FisrtName nvarchar,
	@LastName nvarchar,
	@CompanyID int,
	@Email nvarchar,
	@Password nvarchar,
	@IsActual bit
AS
	INSERT INTO [HRAppDB].[Users](
		[HRAppDB].[Users].[FisrtName],
		[HRAppDB].[Users].[LastName],
		[HRAppDB].[Users].[CompanyID],
		[HRAppDB].[Users].[Email],
		[HRAppDB].[Users].[Password],
		[HRAppDB].[Users].[IsActual]
		)
	VALUES (
		@FisrtName,
		@LastName,
		@CompanyID,
		@Email,
		@Password,
		@IsActual
	)
