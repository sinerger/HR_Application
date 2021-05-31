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
        private string _connectionString = @"Server=(LocalDB)\MSSQLLocalDB; DataBase = Test 2; Trusted_Connection = True; Integrated Security = True;";
        [Test]
        public void Test()
        {
            var repository = new EmployeeProjectsWithDirectionRepository(_connectionString);

            var actual = repository.GetALL();
        }
    }
}