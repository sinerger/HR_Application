CREATE PROCEDURE [dbo].[CompaniesDepartments]
AS
SELECT    c.[ID] AS IDCompany,
c.[Description] AS CompanyDescription,
c.[Title] AS CompanyTitle,
c.[IsActual] AS CompanyIsActual,
cl.[ID] AS IDCompany_Location,
cl.[IsActual] AS Company_LocationIsActual,
cl.[LocationID],
cd.[ID] AS IDCompanies_Depatments,
cd.[IsActual] AS Companies_DepatmentsIsActual,
d.[ID] AS IDDepartment,
d.[Title] AS DepartmentTitle,
d.[Description] AS DepartmentDescription
FROM         HRAppDB.Companies AS c 
RIGHT JOIN HRAppDB.Companies_Locations AS cl
	ON  c.ID = cl.CompanyID
LEFT JOIN   HRAppDB.Companies_Depatments AS cd
	ON c.ID = cd.CompanyID
INNER JOIN HRAppDB.Departments as d
	ON d.ID = cd.DepartmentID
