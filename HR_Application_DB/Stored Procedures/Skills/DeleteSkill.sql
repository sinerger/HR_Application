CREATE PROCEDURE [dbo].[DeleteSkill]
	@ID int
AS
	DELETE
	FROM [dbo].[Skills]
	WHERE [dbo].[Skills].[ID] = @ID