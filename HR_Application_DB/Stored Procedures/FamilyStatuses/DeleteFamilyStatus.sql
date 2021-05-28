CREATE PROCEDURE [dbo].[DeleteFamilyStatus]
	@ID int
AS
	DELETE
	FROM [dbo].[FamilyStatuses]
	WHERE [dbo].[FamilyStatuses].[ID] = @ID