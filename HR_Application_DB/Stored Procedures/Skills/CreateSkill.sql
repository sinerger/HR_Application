CREATE PROCEDURE [HRAppDB].[CreateSkill]
	@Title nvarchar,
	@Description nvarchar
AS
	INSERT INTO [HRAppDB].[Skills](
		[HRAppDB].[Skills].[Title],
		[HRAppDB].[Skills].[Description]
		)
	VALUES (
		@Title,
		@Description
	)
