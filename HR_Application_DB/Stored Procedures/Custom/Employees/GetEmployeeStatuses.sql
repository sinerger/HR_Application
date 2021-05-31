CREATE PROCEDURE [HRAppDB].[GetEmployeeStatuses]
AS
SELECT
em.ID,
em.Photo,
em.FirstName,
em.LastName,
em.RegistationDate,
em.LocationID,
em.IsActual,
st.ID as IDStatuses,
st.[Name]
FROM [HRAppDB].[Employees] as em 
INNER JOIN [HRAppDB].[Statuses] as st
ON
em.StatusID=st.ID