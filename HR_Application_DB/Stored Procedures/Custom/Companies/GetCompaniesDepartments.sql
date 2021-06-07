CREATE PROCEDURE [HRAppDB].[GetCompaniesDepartments]
AS
SELECT
	[HRAppDB].Companies_Depatments.CompanyID as ID, 
	[HRAppDB].Departments.ID, 
	[HRAppDB].Departments.Title, 
	[HRAppDB].Departments.[Description]
FROM [HRAppDB].Companies 
INNER JOIN
	[HRAppDB].Companies_Depatments 
	ON 
	[HRAppDB].Companies.ID = [HRAppDB].Companies_Depatments.CompanyID 
INNER JOIN
	[HRAppDB].Departments 
	ON 
	[HRAppDB].Companies_Depatments.DepartmentID = [HRAppDB].Departments.ID