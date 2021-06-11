CREATE PROCEDURE [HRAppDB].[CreateHistories]
@Table nvarchar (255),
@CollumnName nvarchar (255),
@OldValue nvarchar (255),
@NewValue nvarchar (255),
@UpdatedBy int,
@Updated nvarchar (255)

AS
INSERT INTO [HRAppDB].[Histories](
[HRAppDB].[Histories].[Table],
[HRAppDB].[Histories].CollumnName,
[HRAppDB].[Histories].OldValue,
[HRAppDB].[Histories].NewValue,
[HRAppDB].[Histories].UpdatedBy,
[HRAppDB].[Histories].Updated
)
VALUES(
@Table,
@CollumnName,
@OldValue,
@NewValue,
@UpdatedBy,
@Updated
)