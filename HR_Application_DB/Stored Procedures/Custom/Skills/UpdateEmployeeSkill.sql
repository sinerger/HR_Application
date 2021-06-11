CREATE PROCEDURE [dbo].[UpdateEmployeeSkill]
@ID int,
@EmployeeID int,
@Date nvarchar,
@IsActual bit,
@UserID int,
@LevelSkillID int,
@SkillID int

AS
UPDATE [HRAppDB].[Employees_Skills]
SET 
[HRAppDB].[Employees_Skills].ID=@ID,
[HRAppDB].[Employees_Skills].EmployeeID=@EmployeeID,
[HRAppDB].[Employees_Skills].[Date]=@Date,
[HRAppDB].[Employees_Skills].IsActual=@IsActual,
[HRAppDB].[Employees_Skills].UserID=@UserID,
[HRAppDB].[Employees_Skills].LevelSkillID=@LevelSkillID,
[HRAppDB].[Employees_Skills].SkillID=@SkillID
