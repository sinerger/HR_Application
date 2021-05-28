CREATE PROCEDURE [dbo].[DeleteGeneralInformation]
	@ID int
AS
	Delete from [dbo].[GeneralInformation]
	where [dbo].[GeneralInformation].ID = @ID