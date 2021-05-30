CREATE PROCEDURE [dbo].[GetCompaniesDepartments]
AS
SELECT    c.[ID] AS IDCompany,
c.[Title] AS CompanyTitle,
c.[LocationID],
c.[Description] AS CompanyDescription,
c.[IsActual] AS CompanyIsActual,
cd.[ID] AS IDCompanies_Depatments,
d.[ID] AS IDDepartment,
d.[Title] AS DepartmentTitle,
d.[Description] AS DepartmentDescription
FROM         HRAppDB.Companies AS c 
LEFT JOIN   HRAppDB.Companies_Depatments AS cd
	ON c.ID = cd.CompanyID
LEFT JOIN HRAppDB.Departments as d
	ON d.ID = cd.DepartmentID
	WHERE (c.IsActual = 1) AND (cd.IsActual = 1)