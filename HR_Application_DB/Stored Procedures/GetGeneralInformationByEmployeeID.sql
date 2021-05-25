Create Procedure GetGeneralInformationByEmployeeID
@EmployeeID int 

as

select * from [dbo].[GeneralInformation]
where [dbo].[GeneralInformation].EmployeeID = @EmployeeID