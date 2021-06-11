CREATE PROCEDURE [HRAppDB].[GetCompaniesDepartments]
AS
SELECT
	[HRAppDB].[Companies_Depatments].ID, 
	[HRAppDB].[Companies_Depatments].CompanyID, 
	[HRAppDB].[Companies_Depatments].IsActual, 
	[HRAppDB].[Companies_Depatments].[DepartmentID] as ID

FROM [HRAppDB].[Companies_Depatments]