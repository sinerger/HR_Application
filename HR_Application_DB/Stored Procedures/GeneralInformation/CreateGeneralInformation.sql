CREATE PROCEDURE [HRAppDB].[CreateGeneralInformation]
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
insert into [HRAppDB].[GeneralInformation]
values(
	@EmployeeID,
	@Sex,
	@Education,
	@FamilyStatusID,
	@Phone,
	@Email,
	@BirthDate,
	@Hobby,
	@AmountChildren)
