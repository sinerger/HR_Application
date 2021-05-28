CREATE PROCEDURE [dbo].[CreateHistories]
@Table nvarchar(255),
@CollumnName nvarchar(255),
@OldValue nvarchar(255),
@NewValue nvarchar(255),
@UpdatedBy int,
@Updated datetime

AS
INSERT INTO [dbo].[Histories](
[dbo].[Histories].[Table],
[dbo].[Histories].CollumnName,
[dbo].[Histories].OldValue,
[dbo].[Histories].NewValue,
[dbo].[Histories].UpdatedBy,
[dbo].[Histories].Updated
)
VALUES(
[Table],
CollumnName,
OldValue,
NewValue,
UpdatedBy,
Updated
)