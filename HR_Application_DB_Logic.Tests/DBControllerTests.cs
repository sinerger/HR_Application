using HR_Application_DB_Logic.Models;
using HR_Application_DB_Logic.Tests.Sousces;
using HR_Application_DB_Logic.DBController;
using NUnit.Framework;
using System.Collections.Generic;

namespace HR_Application_DB_Logic.DBController.Tests
{
    public class DBControllerTests
    {
        [Test]
        public void Test()
        {
            var contr = DBController.GetController();

            var actual = contr.EmployeeRepository.GetDTOByID(1);

        }
    }
}