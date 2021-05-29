CREATE PROCEDURE [HRAppDB].[GetFamilyStatusByID]
	@ID int
AS
	SELECT * from [HRAppDB].[FamilyStatuses]
	where [HRAppDB].[FamilyStatuses].ID = @ID