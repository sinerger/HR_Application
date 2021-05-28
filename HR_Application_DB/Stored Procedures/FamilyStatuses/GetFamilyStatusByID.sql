CREATE PROCEDURE [dbo].[GetFamilyStatusByID]
	@ID int
AS
	SELECT * from [dbo].[FamilyStatuses]
	where [dbo].[FamilyStatuses].ID = @ID