using System;
using System.Collections.Generic;
using System.Text;
using HR_Application_BLL.Controllers;
using HR_Application_BLL.Models;
using HR_Application_BLL.Tests.Souces;
using HR_Application_DB_Logic;
using HR_Application_DB_Logic.Interfaces;
using HR_Application_DB_Logic.Models;
using Moq;
using NUnit.Framework;

namespace HR_Application_BLL.Tests
{
    public class UserMapperTests
    {
        private Mock<IDBController> _mock;
        private UserMapper _userMapper;

        [SetUp]
        public void Setup()
        {
            _mock = new Mock<IDBController>();
            _userMapper = new UserMapper(_mock.Object); 

        }

        [TestCaseSource(typeof(GetAllFromUserDTOToUserModelSource))]
        public void GetAllFromUserDTOToUserModel_WhenValidTestPassed_ShouldReturnListUserModel(List<UserDTO> returnedUsersDTO,List<UserModel> expected)
        {
            _mock.Setup(getAll => (getAll.UserRepository.GetAll())).Returns(returnedUsersDTO);
            List<UserModel> actual = _userMapper.GetAllUserModelsFromUserDTO();

            Assert.AreEqual(expected, actual);
        }
        [TestCaseSource(typeof(GetUserDTOFromUserModelSource))]
        public void GetUserDTOFromUserModel_WhenValidTestPassed_ShouldReturnUserDTO(UserModel userModel, UserDTO expected)
        {
            UserDTO actual = _userMapper.GetUserDTOFromUserModel(userModel);

            Assert.AreEqual(expected, actual);
        }
    }
}
