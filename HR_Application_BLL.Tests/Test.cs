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
            var a = new UserService(new DBController(@"Server=(LocalDB)\MSSQLLocalDB;Database =test data 4;Integrated Security=true;")).GetAll();
            string str = a.ToString();
        }
    }
}
