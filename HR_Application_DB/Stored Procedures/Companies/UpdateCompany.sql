CREATE PROCEDURE [HRAppDB].[UpdateCompany]
	@ID int,
	@Title nvarchar,
	@LocationID int,
	@Description nvarchar
AS
	update [HRAppDB].[Companies]
	set
	[HRAppDB].[Companies].Title = @Title,
	[HRAppDB].[Companies].LocationID = @LocationID,
	[HRAppDB].[Companies].[Description] = @Description
	
	where [HRAppDB].[Companies].ID = @ID