CREATE PROCEDURE [HRAppDB].[CreateFamilyStatus]
	@Status nvarchar (255)
AS
INSERT INTO [HRAppDB].[FamilyStatuses] (
		[HRAppDB].[FamilyStatuses].[Status]
		)
		VALUES (
		@Status
		)