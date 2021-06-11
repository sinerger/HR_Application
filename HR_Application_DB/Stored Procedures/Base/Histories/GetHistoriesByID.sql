CREATE PROCEDURE [HRAppDB].[GetHistoriesByID]
@ID int 
AS
    SELECT * FROM [HRAppDB].[Histories]
    WHERE [HRAppDB].[Histories].ID=@ID


   
