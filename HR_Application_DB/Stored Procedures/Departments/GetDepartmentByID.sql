CREATE PROCEDURE [dbo].[GetDepartmentByID]
	@ID int
AS
	select * from [dbo].[Departments]
	where [dbo].[Departments].ID=@ID
