﻿CREATE PROCEDURE [dbo].[GetDepartmentsProjectsByDepartmentID]
@ID int
AS
SELECT
dp.[ID],
d.[ID],
d.[Title],
d.[Description],
dp.[ProjectID] as ID

FROM         HRAppDB.Departments AS d 
INNER JOIN HRAppDB.Departments_Projects AS dp
 ON  d.ID = dp.DepartmentID
 WHERE (dp.[IsActual] = 1) AND (d.ID = @ID)