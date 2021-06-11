CREATE PROCEDURE [HRAppDB].[UpdateCompanyDepartments]
	@ID int,
	@DepartmentID int,
	@CompanyID int
AS
	UPDATE [HRAppDB].[Companies_Depatments]
	SET
	[HRAppDB].[Companies_Depatments].[DepartmentID] = @DepartmentID,
	[HRAppDB].[Companies_Depatments].[CompanyID] = @CompanyID
	WHERE
	[HRAppDB].[Companies_Depatments].[ID] = @ID