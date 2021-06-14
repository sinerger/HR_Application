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
        private string _connectionString2 = @"Server=(LocalDB)\MSSQLLocalDB;Database =tesat db 6;Integrated Security=true;";


        [Test]
        public void Test()
        {

            var a = new DBController(_connectionString2);
            var c = (DepartmentProjectsRepository)a.DepartmentProjectsRepository;
            var b = c.Create(new Models.Base.DepartmentProjectsDTO()
            {
                DepartmentID = 1,
                ProjectsID = new List<int>()
                {
                    1,2,3
                }
            });
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