CREATE PROCEDURE [HRAppDB].[DepartmentsProjects]
AS
SELECT    d.[ID] AS IDDepartment,
d.[Title] AS DepartmentTitle,
d.[Description] AS DepartmentDescription,
dp.[ID] AS IDDepartments_Projects,
dp.[ProjectID]

FROM         HRAppDB.Departments AS d 
INNER JOIN HRAppDB.Departments_Projects AS dp
 ON  d.ID = dp.DepartmentID
 WHERE (dp.[IsActual] = 1)
