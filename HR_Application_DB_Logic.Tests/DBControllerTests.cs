using HR_Application_DB_Logic.Models;
using HR_Application_DB_Logic.Tests.Sousces;
using NUnit.Framework;
using System.Collections.Generic;

namespace HR_Application_DB_Logic.Tests
{
    public class DBControllerTests
    {
        [TestCaseSource(typeof(GeneralInformationSousec))]
        public void GetGeneralInformationDTOByEmployeeID_WhenValidTestPassed_ShouldReturnNewDTO(int actualEmployeeID, List<GeneralInformationDTO> expected)
        {
            List<GeneralInformationDTO> actual = new List<GeneralInformationDTO>();
            actual = DBController.GetGeneralInformationDTOByEmployeeID(actualEmployeeID);

            Assert.AreEqual(expected, actual);
        }
    }
}