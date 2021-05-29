CREATE TABLE [HRAppDB].[Histories] (
    [ID]          INT            IDENTITY (1, 1) NOT NULL,
    [Table]       NVARCHAR (255) NOT NULL,
    [CollumnName] NVARCHAR (255) NOT NULL,
    [OldValue]    NVARCHAR (255) NULL,
    [NewValue]    NVARCHAR (255) NOT NULL,
    [UpdatedBy]   INT            NOT NULL,
    [Updated]     DATETIME       NOT NULL,
    CONSTRAINT [PK_HISTORIES] PRIMARY KEY CLUSTERED ([ID] ASC),
    CONSTRAINT [Histories_fk0] FOREIGN KEY ([UpdatedBy]) REFERENCES [HRAppDB].[Users] ([ID])
);

