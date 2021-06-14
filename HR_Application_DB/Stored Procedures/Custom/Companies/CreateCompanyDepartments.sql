CREATE PROCEDURE [HRAppDB].[CreateCompanyDepartments]
	 @CompanyID int,
 @DepartmentID int,
 @IsActual bit
AS
 INSERT INTO [HRAppDB].[Companies_Depatments]
 OUTPUT INSERTED.[ID]
 VALUES (
 @CompanyID,
 @DepartmentID,
 @IsActual)