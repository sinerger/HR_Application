CREATE PROCEDURE [HRAppDB].[UpdateGeneralInformation]
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

	UPDATE [HRAppDB].[GeneralInformation]
SET	[HRAppDB].[GeneralInformation].EmployeeID = @EmployeeID,
	[HRAppDB].[GeneralInformation].Sex = @Sex,
	[HRAppDB].[GeneralInformation].Education = @Education,
	[HRAppDB].[GeneralInformation].FamilyStatusID = @FamilyStatusID,
	[HRAppDB].[GeneralInformation].Phone = @Phone,
	[HRAppDB].[GeneralInformation].Email = @Email,
	[HRAppDB].[GeneralInformation].BirthDate = @BirthDate,
	[HRAppDB].[GeneralInformation].Hobby = @Hobby,
	[HRAppDB].[GeneralInformation].AmountChildren = @AmountChildren

WHERE  [HRAppDB].[GeneralInformation].ID = @ID
