using Dapper;
using HR_Application_DB_Logic.Models;
using HR_Application_DB_Logic.Repositories;
using HR_Application_DB_Logic.Tests.Sousces;
using Moq;
using Moq.Dapper;
using NUnit.Framework;
using System.Collections.Generic;
using System.Data;
using System.Linq;

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
            var actual = new EmployeeSkillRepository(@"Server=(LocalDB)\MSSQLLocalDB; DataBase = EmployeeDB; Trusted_Connection = True; Integrated Security = True;");

            var a = actual.GetAll();
            Assert.NotNull(a);
        }

        [Test]
        public void Test2()
        {
            var actual = new SkillRepository(@"Server=(LocalDB)\MSSQLLocalDB; DataBase = EmployeeDB; Trusted_Connection = True; Integrated Security = True;");

            var a = actual.GetByTitle("a");

            Assert.NotNull(a);
        }

        [Test]
        public void QueryGeneric()
        {
            var connection = new Mock<IDbConnection>();

            var expected = new[] { 7, 77, 777 };

            connection.SetupDapper(c => c.Query<int>(It.IsAny<string>(), null, null, true, null, null))
                      .Returns(expected);

            var actual = connection.Object.Query<int>("").ToList();

            Assert.That(actual.Count, Is.EqualTo(expected.Length));
            Assert.That(actual, Is.EquivalentTo(expected));
        }
        [Test]
        public void Test3()
        {
            var dbConnection = new Mock<IDbConnection>();

            var expected = new[]
            {
                new CountryDTO(){ ID = 1,Name = "Ukraine"},
                new CountryDTO(){ ID = 2,Name = "Poland"}
            };

            dbConnection.SetupDapper(connection => connection.Query<CountryDTO>(It.IsAny<string>(), null, null, true, null, null))
                .Returns(expected);
            
            var actual = dbConnection.Object.Query<CountryDTO>("Test", null, null, true, null, null).ToList();

            //Assert.That(actual.Count, Is.EqualTo(expected.Length));
            Assert.AreEqual(expected.Length, actual.Count);
        }

        //[Test]
        //    public void QueryGenericComplexType()
        //    {
        //        var connection = new Mock<IDbConnection>();

        //        var expected = new[]
        //        {
        //    new ComplexType { StringProperty = "String1", IntegerProperty = 7 },
        //    new ComplexType { StringProperty = "String2", IntegerProperty = 77 },
        //    new ComplexType { StringProperty = "String3", IntegerProperty = 777 }
        //};

        //        connection.SetupDapper(c => c.Query<ComplexType>(It.IsAny<string>(), null, null, true, null, null))
        //                  .Returns(expected);

        //        var actual = connection.Object.Query<ComplexType>("", null, null, true, null, null).ToList();

        //        Assert.That(actual.Count, Is.EqualTo(expected.Length));

        //        foreach (var complexObject in expected)
        //        {
        //            var match = actual.Where(co => co.StringProperty == complexObject.StringProperty && co.IntegerProperty == complexObject.IntegerProperty);

        //            Assert.That(match.Count, Is.EqualTo(1));
        //        }
        //    }
        //}
    }
}