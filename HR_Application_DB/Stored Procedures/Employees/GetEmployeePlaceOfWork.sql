CREATE PROCEDURE [dbo].[GetEmployeePlaceOfWork]
AS
	SELECT
	Empl.[ID] as EmplID, Empl.[Photo], Empl.[FirstName], Empl.[LastName], Empl.[RegistationDate], Empl.[IsActual],
	Sk.Title, Sk.Description, Ls.Title
FROM [dbo].[Employees] as Empl
JOIN [dbo].[Employees_Skills] as Em_Sk
  ON Empl.id = Em_Sk.[EmployeeID]
JOIN LevelSkills as Ls
  ON Ls.[ID] = Em_Sk.LevelSkillID
JOIN [dbo].[Skills] as Sk
  ON Sk.[ID] = Em_Sk.SkillID
