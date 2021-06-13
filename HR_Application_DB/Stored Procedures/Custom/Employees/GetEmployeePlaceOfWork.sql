CREATE PROCEDURE [HRAppDB].[GetEmployeePlaceOfWork]
AS
	SELECT
	Empl.[ID], 
	Empl.[Photo], 
	Empl.[FirstName], 
	Empl.[LastName], 
	Empl.[RegistrationDate], 
	Empl.[IsActual],
	Sk.Title,
	Sk.[Description],
	Ls.Title
FROM [HRAppDB].[Employees] as Empl

JOIN [HRAppDB].[Employees_Skills] as Em_Sk
  ON 
  Empl.id = Em_Sk.[EmployeeID]
JOIN LevelSkills as Ls
  ON 
  Ls.[ID] = Em_Sk.LevelSkillID
JOIN [HRAppDB].[Skills] as Sk
  ON 
  Sk.[ID] = Em_Sk.SkillID
