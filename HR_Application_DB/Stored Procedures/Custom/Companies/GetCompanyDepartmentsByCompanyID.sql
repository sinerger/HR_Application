CREATE PROCEDURE [HRAppDB].[GetCompanyDepartmentsByCompanyID]
@ID int
AS
SELECT
	[HRAppDB].[Companies_Depatments].ID,
	[HRAppDB].[Companies_Depatments].CompanyID, 
	[HRAppDB].[Companies_Depatments].IsActual, 
	[HRAppDB].[Companies_Depatments].DepartmentID AS ID

FROM [HRAppDB].[Companies_Depatments] 

WHERE [HRAppDB].[Companies_Depatments].[ID] = @ID