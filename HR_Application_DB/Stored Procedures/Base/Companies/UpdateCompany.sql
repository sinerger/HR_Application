CREATE PROCEDURE [HRAppDB].[UpdateCompany]
	@ID int,
	@Title nvarchar (255),
	@LocationID int,
	@Description nvarchar (255),
	@IsActual bit
AS
	update [HRAppDB].[Companies]
	set
	[HRAppDB].[Companies].Title = @Title,
	[HRAppDB].[Companies].LocationID = @LocationID,
	[HRAppDB].[Companies].[Description] = @Description,
	[HRAppDB].[Companies].[IsActual] = @IsActual
	
	where [HRAppDB].[Companies].ID = @ID