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
            var repository = new UserRepository(_connectionString2);

            var actual = repository.GetAll();
        }
    }
}