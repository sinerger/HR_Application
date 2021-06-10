using HR_Application_BLL.Base.Models;
using HR_Application_BLL.Mappers;
using HR_Application_BLL.Models;
using HR_Application_BLL.Tests.Souces.UserSource;
using HR_Application_DB_Logic.Models;
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

        [TestCaseSource(typeof(UserMapperGetUsersFromModelsSource))]
        public void GetUsersFromModels_WhenValidTestPassed_ShoukdReturnListUser(List<UserDTO> userDTO, List<User> expected)
        {
            List<User> actual = _userMapper.GetUsersFromDTO(userDTO);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(null)]
        public void GetUsersFromModels_WhenInvalidTestPassed_ShoukdReturnListUser(List<UserDTO> userDTO)
        {
            Assert.Throws<ArgumentNullException>(()=> _userMapper.GetUsersFromDTO(userDTO));
        }

        [TestCaseSource(typeof(UserMapperGetUserFromModelSource))]
        public void GetUserFromModel_WhenValidTestPassed_ShoukdReturnListUser(UserDTO userDTO, User expected)
        {
            User actual = _userMapper.GetUserFromDTO(userDTO);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(null)]
        public void GetUserFromModel_WhenInvalidTestPassed_ShoukdReturnListUser(UserDTO userDTO)
        {
            Assert.Throws<ArgumentNullException>(() => _userMapper.GetUserFromDTO(userDTO));
        }

        [TestCaseSource(typeof(UserMapperGetModelFromUserSource))]
        public void GetModelFromUser_WhenValidTestPassed_ShouldReturnUserModel(User user, UserDTO expected)
        {
            UserDTO actual = _userMapper.GetDTOFromUser(user);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(null)]
        public void GetModelFromUser_WhenInvalidTestPassed_ShoukdReturnListUser(User user)
        {
            Assert.Throws<ArgumentNullException>(() => _userMapper.GetDTOFromUser(user));
        }
    }
}
