CREATE PROCEDURE [dbo].[UpdateHistories]
@ID int,
@Table nvarchar(255),
@CollumnName nvarchar(255),
@OldValue nvarchar(255),
@NewValue nvarchar(255),
@UpdatedBy int,
@Updated datetime
AS
UPDATE [dbo].[Histories]
SET [dbo].[Histories].[Table]=@Table,
    [dbo].[Histories].CollumnName=@CollumnName,
    [dbo].[Histories].OldValue=@OldValue,
    [dbo].[Histories].NewValue=@NewValue,
    [dbo].[Histories].UpdatedBy=@UpdatedBy,
    [dbo].[Histories].Updated=@Updated
    WHERE     [dbo].[Histories].ID=@ID