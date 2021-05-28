CREATE PROCEDURE [dbo].[UpdateFamilyStatus]
	@ID int,
	@Status nvarchar(30)
AS
UPDATE [dbo].[FamilyStatuses]
SET [dbo].[FamilyStatuses].[Status] = @Status
WHERE [dbo].[FamilyStatuses].[ID] = @ID