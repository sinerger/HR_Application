CREATE PROCEDURE [HRAppDB].[DeleteFamilyStatus]
	@ID int
AS
	DELETE
	FROM [HRAppDB].[FamilyStatuses]
	WHERE [HRAppDB].[FamilyStatuses].[ID] = @ID