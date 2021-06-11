CREATE PROCEDURE [HRAppDB].[CreateEmployeeSkill]
@EmployeeID int,
@Date nvarchar (255),
@IsActual bit,
@UserID int,
@LevelSkillID int,
@SkillID int

AS
INSERT INTO [HRAppDB].[Employees_Skills](
[HRAppDB].[Employees_Skills].EmployeeID,
[HRAppDB].[Employees_Skills].[Date],
[HRAppDB].[Employees_Skills].IsActual,
[HRAppDB].[Employees_Skills].UserID,
[HRAppDB].[Employees_Skills].LevelSkillID,
[HRAppDB].[Employees_Skills].SkillID)

VALUES(
@EmployeeID,
@Date,
@IsActual,
@UserID,
@LevelSkillID,
@SkillID)
