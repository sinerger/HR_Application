CREATE PROCEDURE [HRAppDB].[UpdateHistories]
@ID int,
@Table nvarchar(255),
@CollumnName nvarchar(255),
@OldValue nvarchar(255),
@NewValue nvarchar(255),
@UpdatedBy int,
@Updated datetime
AS
UPDATE [HRAppDB].[Histories]
SET [HRAppDB].[Histories].[Table]=@Table,
    [HRAppDB].[Histories].CollumnName=@CollumnName,
    [HRAppDB].[Histories].OldValue=@OldValue,
    [HRAppDB].[Histories].NewValue=@NewValue,
    [HRAppDB].[Histories].UpdatedBy=@UpdatedBy,
    [HRAppDB].[Histories].Updated=@Updated
    WHERE     [HRAppDB].[Histories].ID=@ID