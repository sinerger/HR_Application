using HR_Application_BLL.Mappers;
using HR_Application_BLL.Models;
using HR_Application_DB_Logic.Models;
using HR_Application_BLL.Tests.Souces.User;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace HR_Application_BLL.Tests.TestsClases
{
    class UserModelMapperTests
    {
        private UserModelMapper _userMapper;

        [SetUp]
        public void Setup()
        {
            _userMapper = new UserModelMapper();
        }

        [TestCaseSource(typeof(GetModelsFromDTOSource))]
        public void GetModelsFromDTO_WhenValidTestPassed_ShouldReturnListCountryModels(List<UserDTO> actualUsersDTO, List<UserModel> expected)
        {
            List<UserModel> actual = _userMapper.GetModelsFromDTO(actualUsersDTO);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(null)]
        public void GetModelsFromDTO_WhenInvaildTestPassed_ShouldReturnArgumentNullException(List<UserDTO> countryModel)
        {
            Assert.Throws<ArgumentNullException>(() => _userMapper.GetModelsFromDTO(countryModel));
        }

        [TestCaseSource(typeof(GetModelFromDTOSource))]
        public void GetModelFromDTO_WhenValidTestPassed_ShouldReturnCountryModelByID(UserDTO actualCountryDTO, UserModel expected)
        {
            UserModel actual = _userMapper.GetModelFromDTO(actualCountryDTO);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(null)]
        public void GetModelFromDTO_WhenInvaildTestPassed_ShouldReturnArgumentNullException(UserDTO countryModel)
        {
            Assert.Throws<ArgumentNullException>(() => _userMapper.GetModelFromDTO(countryModel));
        }

        [TestCaseSource(typeof(GetDTOFromModelSource))]
        public void GetDTOFromModel_WhenValidTestPassed(UserModel userModel, UserDTO expected)
        {
            UserDTO actual = _userMapper.GetDTOFromModel(userModel);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(null)]
        public void GetCountryDTOFromCountryModel_WhenInvaildTestPassed_ShouldReturnArgumentNullException(UserModel userModel)
        {
            Assert.Throws<ArgumentNullException>(() => _userMapper.GetDTOFromModel(userModel));
        }
    }
}
