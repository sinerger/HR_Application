CREATE PROCEDURE [HRAppDB].[GetHistoriesByTable]
	@Table nvarchar
AS
	SELECT * FROM [HRAppDB].[Histories]
    WHERE [HRAppDB].[Histories].[Table]=@Table
