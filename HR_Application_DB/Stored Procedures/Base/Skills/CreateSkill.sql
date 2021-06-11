CREATE PROCEDURE [HRAppDB].[CreateSkill]
	@Title nvarchar (255),
	@Description nvarchar (255)
AS
	INSERT INTO [HRAppDB].[Skills](
		[HRAppDB].[Skills].[Title],
		[HRAppDB].[Skills].[Description]
		)
	VALUES (
		@Title,
		@Description
	)
