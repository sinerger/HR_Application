CREATE PROCEDURE [HRAppDB].[GetCompaniesDepartments]
AS
SELECT   
cd.ID as IDCompanyDepartments,
c.[ID],
c.[Title] ,
c.[LocationID],
c.[Description] ,
c.[IsActual] ,
d.[ID] AS IDDepartment
FROM	HRAppDB.Companies AS c 
LEFT JOIN  
	HRAppDB.Companies_Depatments AS cd
ON 
	c.ID = cd.CompanyID
LEFT JOIN 
	HRAppDB.Departments as d
ON 
	d.ID = cd.DepartmentID

WHERE (c.IsActual = 1) AND (cd.IsActual = 1)