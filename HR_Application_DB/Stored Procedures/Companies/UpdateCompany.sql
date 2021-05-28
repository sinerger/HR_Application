CREATE PROCEDURE [dbo].[UpdateCompany]
	@ID int,
	@Title nvarchar,
	@LocationID int,
	@Description nvarchar
AS
	update [dbo].[Companies]
	set
	[dbo].[Companies].Title = @Title,
	[dbo].[Companies].LocationID = @LocationID,
	[dbo].[Companies].[Description] = @Description
	
	where [dbo].[Companies].ID = @ID