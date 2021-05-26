CREATE PROCEDURE [dbo].[GetSkillByID]
	@ID int
	
AS
	SELECT * FROM [dbo].[Skills]
	WHERE [dbo].[Skills].[ID] = @ID