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


        [Test]
        public void Test()
        {
            var repository = new CompanyDepartmentsRepository(_connectionString);

            //var actual = repository.GetALLByCompanyID(1);
        }
    }
}