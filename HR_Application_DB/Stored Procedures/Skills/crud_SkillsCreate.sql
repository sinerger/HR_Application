﻿CREATE PROCEDURE [dbo].[crud_SkillsCreate]
	@Title nvarchar,
	@Description nvarchar
AS
	INSERT INTO [dbo].[Skills](
		[dbo].[Skills].[Title],
		[dbo].[Skills].[Description]
		)
	VALUES (
		@Title,
		@Description
	)
