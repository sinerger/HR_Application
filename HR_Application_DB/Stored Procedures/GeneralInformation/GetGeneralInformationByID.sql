CREATE PROCEDURE [dbo].[GetGeneralInformationByID]
	@ID int
AS
	SELECT * from [dbo].[GeneralInformation]
	where [dbo].[GeneralInformation].ID=@ID