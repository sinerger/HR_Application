CREATE PROCEDURE [HRAppDB].[DeleteCompanyDepartments]
	@ID int
AS
	DELETE FROM [HRAppDB].[Companies_Depatments]
	WHERE [HRAppDB].[Companies_Depatments].[ID] = @ID