CREATE PROCEDURE [HRAppDB].[CreateUsers]
	@FirstName nvarchar (255),
	@LastName nvarchar(255),
	@CompanyID int,
	@Email nvarchar (255),
	@Password nvarchar (255),
	@IsActual bit
AS
	INSERT INTO [HRAppDB].[Users](
		[HRAppDB].[Users].[FirstName],
		[HRAppDB].[Users].[LastName],
		[HRAppDB].[Users].[CompanyID],
		[HRAppDB].[Users].[Email],
		[HRAppDB].[Users].[Password],
		[HRAppDB].[Users].[IsActual]
		)
	OUTPUT INSERTED.[ID]
	VALUES (
		@FirstName,
		@LastName,
		@CompanyID,
		@Email,
		@Password,
		@IsActual
	)
