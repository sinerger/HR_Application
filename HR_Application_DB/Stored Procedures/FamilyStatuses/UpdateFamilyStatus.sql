CREATE PROCEDURE [HRAppDB].[UpdateFamilyStatus]
	@ID int,
	@Status nvarchar(30)
AS
UPDATE [HRAppDB].[FamilyStatuses]
SET [HRAppDB].[FamilyStatuses].[Status] = @Status
WHERE [HRAppDB].[FamilyStatuses].[ID] = @ID