CREATE PROCEDURE [HRAppDB].[CreateFamilyStatus]
	@Status nvarchar
AS
INSERT INTO [HRAppDB].[FamilyStatuses] (
		[HRAppDB].[FamilyStatuses].[Status]
		)
		VALUES (
		@Status
		)