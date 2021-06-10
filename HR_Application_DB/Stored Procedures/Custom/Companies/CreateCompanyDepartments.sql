CREATE PROCEDURE [HRAppDB].[CreateCompanyDepartments]
	@DepartmentID int,
	@CompanyID int,
	@IsActual bit
AS
	INSERT INTO [HRAppDB].[Companies_Depatments]
	VALUES (
	@DepartmentID,
	@CompanyID,
	@IsActual)