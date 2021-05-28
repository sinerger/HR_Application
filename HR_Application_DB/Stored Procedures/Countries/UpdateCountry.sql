CREATE PROCEDURE [dbo].[UpdateCountry]
	@ID int,
	@Name nvarchar
	
AS
	Update [dbo].[Countries]
	set [dbo].[Countries].[Name] = @Name
	where [dbo].[Countries].ID = @ID
