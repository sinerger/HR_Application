CREATE PROCEDURE [HRAppDB].[DeleteGeneralInformation]
	@ID int
AS
	Delete from [HRAppDB].[GeneralInformation]
	where [HRAppDB].[GeneralInformation].ID = @ID