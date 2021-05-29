CREATE PROCEDURE [HRAppDB].[GetUserByName]
	@LastName nvarchar
	AS
	SELECT * FROM [HRAppDB].[Users]
	WHERE [HRAppDB].[Users].[LastName] = @LastName
