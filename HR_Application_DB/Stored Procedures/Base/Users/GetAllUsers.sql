CREATE PROCEDURE [HRAppDB].[GetAllUsers]
	AS
	SELECT [HRAppDB].[Users].[ID], [HRAppDB].[Users].[FisrtName], [HRAppDB].[Users].[LastName], [HRAppDB].[Users].[CompanyID], 
	[HRAppDB].[Users].[Email], [HRAppDB].[Users].[Passvord], [HRAppDB].[Users].[IsActual]
	FROM [HRAppDB].[Users]
