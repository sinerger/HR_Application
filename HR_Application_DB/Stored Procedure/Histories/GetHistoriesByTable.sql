CREATE PROCEDURE [dbo].[GetHistoriesByTable]
	@Table nvarchar
AS
	SELECT * FROM [dbo].[Histories]
    WHERE [dbo].[Histories].[Table]=@Table
