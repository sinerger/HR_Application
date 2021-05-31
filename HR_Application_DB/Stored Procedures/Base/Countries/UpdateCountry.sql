CREATE PROCEDURE [HRAppDB].[UpdateCountry]
	@ID int,
	@Name nvarchar
	
AS
	Update [HRAppDB].[Countries]
	set [HRAppDB].[Countries].[Name] = @Name
	where [HRAppDB].[Countries].ID = @ID
