CREATE PROCEDURE [HRAppDB].[SkillsLevelSkills]
AS
SELECT
es.ID as IDEmployees_Skills,
es.[Date],
es.IsActual,
es.UserID,
ls.ID as IDLevelSkills,
ls.Title as TitleLevelSkills,
s.ID as IDSkills,
s.Title as TitleSkills

FROM [HRAppDB].[Employees_Skills] as es

INNER JOIN [HRAppDB].[LevelSkills] as ls 
ON
es.LevelSkillID=ls.ID

INNER JOIN [HRAppDB].[Skills] as s
ON
es.SkillID=s.ID