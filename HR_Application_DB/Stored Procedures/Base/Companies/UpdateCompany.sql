CREATE PROCEDURE [HRAppDB].[UpdateCompany]
	@ID int,
	@Title nvarchar,
	@LocationID int,
	@Description nvarchar,
	@IsActual bit
AS
	update [HRAppDB].[Companies]
	set
	[HRAppDB].[Companies].Title = @Title,
	[HRAppDB].[Companies].LocationID = @LocationID,
	[HRAppDB].[Companies].[Description] = @Description,
	[HRAppDB].[Companies].[IsActual] = @IsActual
	
	where [HRAppDB].[Companies].ID = @ID