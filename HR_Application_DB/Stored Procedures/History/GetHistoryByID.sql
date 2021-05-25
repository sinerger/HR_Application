CREATE PROCEDURE [dbo].[GetHistoryByID]
@ID int 
AS
    SELECT * FROM [dbo].[Histories]
    WHERE [dbo].[Histories].ID=@ID


   
