using HR_Application_DB_Logic.Models;
using HR_Application_DB_Logic.Repositories;
using HR_Application_DB_Logic.Tests.Sousces;
using NUnit.Framework;
using System.Collections.Generic;

namespace HR_Application_DB_Logic.Tests
{
    public class DBControllerTests
    {
        //[TestCaseSource(typeof(GeneralInformationSousec))]
        //public void GetGeneralInformationDTOByEmployeeID_WhenValidTestPassed_ShouldReturnNewDTO(int actualEmployeeID, List<GeneralInformationDTO> expected)
        //{
        //    List<GeneralInformationDTO> actual = new List<GeneralInformationDTO>();
        //    actual = DBController.GetGeneralInformationDTOByEmployeeID(actualEmployeeID);

        //    Assert.AreEqual(expected, actual);
        //}

        //[TestCase(1)]
        //[TestCase(2)]
        //[TestCase(4)]
        //[TestCase(5)]
        //public void GetEmployeeDTOByID_WhenValidTestPassed_ShouldReturnNotNUllDTO(int actualID)
        //{
        //    EmployeeDTO actual = DBController.GetEmployeeDTOByID(actualID);

        //    Assert.NotNull(actual);
        //}

        [Test]
        public void Test()
        {
            var actual = new EmployeeRepository(@"Server=(LocalDB)\MSSQLLocalDB; DataBase = NewEmployeesDB; Trusted_Connection = True; Integrated Security = True;");

            var a = actual.GetByID(1);
        }
    }
}