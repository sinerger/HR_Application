CREATE PROCEDURE [HRAppDB].[GetGeneralInformationByID]
	@ID int
AS
	SELECT * from [HRAppDB].[GeneralInformation]
	where [HRAppDB].[GeneralInformation].ID=@ID