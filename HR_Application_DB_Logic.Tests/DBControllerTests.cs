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
        private string _connectionString = @"Server = 80.78.240.16; Database = Sandbox.Test; User Id = devEd; Password = qqq!11;";
        private string _connectionString2 = @"Server=(LocalDB)\MSSQLLocalDB;Database =test data 4;Integrated Security=true;";


        [Test]
        public void Test()
        {

            var a = new DBController(_connectionString);
            var b=a.LocationRepository.Create(new LocationDTO() { CityID = 1 });
            //var repository = new EmployeeRepository(_connectionString);

            //var actual = repository.Create(new EmployeeDTO()
            //{
            //    FirstName = "56ID",
            //    LastName = "a",
            //    LocationID =1,
            //    RegistrationDate= "10.10.10",
            //    StatusID =1,
            //    IsActual = true
            //});
        }
    }
}