CREATE PROCEDURE [dbo].[GetUserByName]
	@LastName nvarchar
	AS
	SELECT * FROM [dbo].[Users]
	WHERE [dbo].[Users].[LastName] = @LastName
