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
        public void GetUsersFromModels_WhenValidTestPassed_ShoukdReturnListUser(List<UserModel> usersModel, List<Company> companies, List<User> expected)
        {
            List<User> actual = _userMapper.GetUsersFromModels(usersModel, companies);

            Assert.AreEqual(expected, actual);
        }

        [TestCaseSource(typeof(InvalidGetUsersFromModelsSource))]
        public void GetUsersFromModels_WhenInvalidTestPassed_ShoukdReturnListUser(List<UserModel> usersModel, List<Company> companies)
        {
            Assert.Throws<ArgumentNullException>(()=> _userMapper.GetUsersFromModels(usersModel, companies));
        }

        [TestCaseSource(typeof(GetUserFromModelSource))]
        public void GetUserFromModel_WhenValidTestPassed_ShoukdReturnListUser(UserModel userModel, Company company, User expected)
        {
            User actual = _userMapper.GetUserFromModel(userModel, company);

            Assert.AreEqual(expected, actual);
        }

        [TestCaseSource(typeof(InvalidGetUserFromModelsSource))]
        public void GetUserFromModel_WhenInvalidTestPassed_ShoukdReturnListUser(UserModel userModel, Company company)
        {
            Assert.Throws<ArgumentNullException>(() => _userMapper.GetUserFromModel(userModel, company));
        }

        [TestCaseSource(typeof(GetModelFromUserSource))]
        public void GetModelFromUser_WhenValidTestPassed_ShouldReturnUserModel(User user, UserModel expected)
        {
            UserModel actual = _userMapper.GetModelFromUser(user);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(null)]
        public void GetModelFromUser_WhenInvalidTestPassed_ShoukdReturnListUser(User user)
        {
            Assert.Throws<ArgumentNullException>(() => _userMapper.GetModelFromUser(user));
        }
    }
}
