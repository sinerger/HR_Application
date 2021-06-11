CREATE PROCEDURE [HRAppDB].[UpdateCountry]
	@ID int,
	@Name nvarchar (255)
	
AS
	Update [HRAppDB].[Countries]
	set [HRAppDB].[Countries].[Name] = @Name
	where [HRAppDB].[Countries].ID = @ID
