CREATE PROCEDURE [dbo].[GetAllUsers]
	AS
	SELECT [dbo].[Users].[ID], [dbo].[Users].[FisrtName], [dbo].[Users].[LastName], [dbo].[Users].[CompanyID], 
	[dbo].[Users].[Email], [dbo].[Users].[Passvord], [dbo].[Users].[IsActual]
	FROM [dbo].[Users]
