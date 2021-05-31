CREATE PROCEDURE [HRAppDB].[CreateHistories]
@Table nvarchar,
@CollumnName nvarchar,
@OldValue nvarchar,
@NewValue nvarchar,
@UpdatedBy int,
@Updated nvarchar

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