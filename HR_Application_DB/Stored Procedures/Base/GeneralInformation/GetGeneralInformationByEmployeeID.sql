Create Procedure GetGeneralInformationByEmployeeID
@EmployeeID int 

as

select * from [HRAppDB].[GeneralInformation]
where [HRAppDB].[GeneralInformation].EmployeeID = @EmployeeID