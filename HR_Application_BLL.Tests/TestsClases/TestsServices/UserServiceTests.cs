using HR_Application_BLL.Services;
using HR_Application_DB_Logic.Interfaces;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace HR_Application_BLL.Tests.TestsClases.TestsServices
{
    public class UserServiceTests
    {
        private Mock<IDBController> _mock;
        private UserService _userService;

        [SetUp]
        public void Setup()
        {
            _mock = new Mock<IDBController>();
            _userService = new UserService(_mock.Object);
        }
    }
}
