using HR_Application_BLL.Base.Models;
using HR_Application_BLL.Mappers;
using HR_Application_BLL.Models;
using HR_Application_BLL.Tests.Souces.UserSource;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace HR_Application_BLL.Tests.TestsClases
{
    public class UserMapperTests
    {
        private UserMapper _userMapper;

        [SetUp]
        public void Setup()
        {
            _userMapper = new UserMapper();
        }

        [TestCaseSource(typeof(GetUsersFromModelsSource))]
        public void GetUsersFromModels_WhenValidTestPassed_ShoukdReturnListUser(List<UserModel> usersModel, List<Company> companies,List<User> expected)
        {
            List<User> actual = _userMapper.GetUsersFromModels(usersModel, companies);

            Assert.AreEqual(expected, actual);
        }
    }
}
