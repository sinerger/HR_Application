CREATE PROCEDURE [HRAppDB].[GeneralInformationFamilyStatuses]
AS
SELECT 
gi.ID,
gi.EmployeeID,
gi.Sex,
gi.Education,
gi.Phone,
gi.Email,
gi.BirthDate,
gi.Hobby,
gi.AmountChildren,
fs.ID as IDFamilyStatuses,
fs.[Status]
FROM [HRAppDB].[GeneralInformation] as gi

INNER JOIN [HRAppDB].[FamilyStatuses] as fs 
ON
gi.FamilyStatusID=fs.ID
