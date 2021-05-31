CREATE PROCEDURE [HRAppDB].[UpdateHistories]
@ID int,
@Table nvarchar,
@CollumnName nvarchar,
@OldValue nvarchar,
@NewValue nvarchar,
@UpdatedBy int,
@Updated nvarchar
AS
UPDATE [HRAppDB].[Histories]
SET [HRAppDB].[Histories].[Table]=@Table,
    [HRAppDB].[Histories].CollumnName=@CollumnName,
    [HRAppDB].[Histories].OldValue=@OldValue,
    [HRAppDB].[Histories].NewValue=@NewValue,
    [HRAppDB].[Histories].UpdatedBy=@UpdatedBy,
    [HRAppDB].[Histories].Updated=@Updated
    WHERE     [HRAppDB].[Histories].ID=@ID