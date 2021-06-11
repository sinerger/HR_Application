CREATE PROCEDURE [HRAppDB].[GetHistoriesByTable]
	@Table nvarchar (255)
AS
	SELECT * FROM [HRAppDB].[Histories]
    WHERE [HRAppDB].[Histories].[Table]=@Table
