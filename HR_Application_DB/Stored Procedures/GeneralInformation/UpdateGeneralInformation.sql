CREATE PROCEDURE [dbo].[UpdateGeneralInformation]
	@ID int ,
	@EmployeeID int,
	@Sex nvarchar,
	@Education nvarchar,
	@FamilyStatusID int,
	@Phone nvarchar,
	@Email nvarchar,
	@BirthDate dateTime,
	@Hobby nvarchar,
	@AmountChildren int

AS

	UPDATE [dbo].[GeneralInformation]
SET	[dbo].[GeneralInformation].EmployeeID = @EmployeeID,
	[dbo].[GeneralInformation].Sex = @Sex,
	[dbo].[GeneralInformation].Education = @Education,
	[dbo].[GeneralInformation].FamilyStatusID = @FamilyStatusID,
	[dbo].[GeneralInformation].Phone = @Phone,
	[dbo].[GeneralInformation].Email = @Email,
	[dbo].[GeneralInformation].BirthDate = @BirthDate,
	[dbo].[GeneralInformation].Hobby = @Hobby,
	[dbo].[GeneralInformation].AmountChildren = @AmountChildren

WHERE  [dbo].[GeneralInformation].ID = @ID
