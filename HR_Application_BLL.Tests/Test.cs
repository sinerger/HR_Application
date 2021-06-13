using System;
using System.Collections.Generic;
using System.Text;
using HR_Application_BLL.Models;
using HR_Application_BLL.Services;
using HR_Application_DB_Logic;
using NUnit.Framework;

namespace HR_Application_BLL.Tests
{
    public class Test
    {
        [Test]
        public void Testas()
        {
            var a = new EmployeeService(new DBController(DBConfigurator.ConnectionString)).GetAll();
            var b = new EmployeeService(new DBController(DBConfigurator.ConnectionString)).GetByID(1);

            //var c = new PositionService(new DBController(DBConfigurator.ConnectionString)).GetAll();
            //string str = a.ToString();
            //var a = new Employee();
            //var b = a.Clone();
            //a.Department = null;

        }
    }
}
