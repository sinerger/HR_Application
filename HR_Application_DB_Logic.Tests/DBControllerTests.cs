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
        
        private  string _connectionString = @"Server=Avakian; DataBase = EmployeeDB; Trusted_Connection = True; Integrated Security = True;";
        [Test]
        public void Test()
        {
            var repository = new AdressRepository(_connectionString);
            var actual = repository.GetAll();
        }
    }
}