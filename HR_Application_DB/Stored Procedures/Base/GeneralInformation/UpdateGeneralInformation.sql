CREATE PROCEDURE [HRAppDB].[UpdateGeneralInformation]
	@ID int ,
	@EmployeeID int,
	@Sex nvarchar (255),
	@Education nvarchar (255),
	@FamilyStatusID int,
	@Phone nvarchar (255),
	@Email nvarchar (255),
	@BirthDate nvarchar (255),
	@Hobby nvarchar (255),
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
