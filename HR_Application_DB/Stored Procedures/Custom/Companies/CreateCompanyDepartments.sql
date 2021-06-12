CREATE PROCEDURE [HRAppDB].[CreateCompanyDepartments]
	@DepartmentID int,
	@CompanyID int,
	@IsActual bit
AS
	INSERT INTO [HRAppDB].[Companies_Depatments]
	OUTPUT INSERTED.[ID]
	VALUES (
	@DepartmentID,
	@CompanyID,
	@IsActual)