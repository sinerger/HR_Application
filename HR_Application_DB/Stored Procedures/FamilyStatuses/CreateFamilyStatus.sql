CREATE PROCEDURE [dbo].[CreateFamilyStatus]
	@Status nvarchar(30)
AS
INSERT INTO [dbo].[FamilyStatuses] (
		[dbo].[FamilyStatuses].[Status]
		)
		VALUES (
		@Status
		)