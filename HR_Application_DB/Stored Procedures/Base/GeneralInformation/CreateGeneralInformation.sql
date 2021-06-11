CREATE PROCEDURE [HRAppDB].[CreateGeneralInformation]
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
