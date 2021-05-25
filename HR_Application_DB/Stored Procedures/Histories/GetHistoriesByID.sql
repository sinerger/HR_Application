CREATE PROCEDURE [dbo].[GetHistoriesByID]
@ID int 
AS
    SELECT * FROM [dbo].[Histories]
    WHERE [dbo].[Histories].ID=@ID


   
