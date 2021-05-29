CREATE PROCEDURE [HRAppDB].[CreateFamilyStatus]
	@Status nvarchar(30)
AS
INSERT INTO [HRAppDB].[FamilyStatuses] (
		[HRAppDB].[FamilyStatuses].[Status]
		)
		VALUES (
		@Status
		)