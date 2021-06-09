using HR_Application_BLL.Mappers;
using HR_Application_DB_Logic.Models;
using HR_Application_BLL.Tests.Souces.UserModelSource;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using HR_Application_BLL.Base.Models;

namespace HR_Application_BLL.Tests.TestsClases
{
    class UserModelMapperTests
    {
        private UserModelMapper _userModelMapper;

        [SetUp]
        public void Setup()
        {
            _userModelMapper = new UserModelMapper();
        }

        [TestCaseSource(typeof(GetModelsFromDTOSource))]
        public void GetModelsFromDTO_WhenValidTestPassed_ShouldReturnListCountryModels(List<UserDTO> actualUsersDTO, List<UserModel> expected)
        {
            List<UserModel> actual = _userModelMapper.GetModelsFromDTO(actualUsersDTO);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(null)]
        public void GetModelsFromDTO_WhenInvaildTestPassed_ShouldReturnArgumentNullException(List<UserDTO> countryModel)
        {
            Assert.Throws<ArgumentNullException>(() => _userModelMapper.GetModelsFromDTO(countryModel));
        }

        [TestCaseSource(typeof(GetModelFromDTOSource))]
        public void GetModelFromDTO_WhenValidTestPassed_ShouldReturnCountryModelByID(UserDTO actualCountryDTO, UserModel expected)
        {
            UserModel actual = _userModelMapper.GetModelFromDTO(actualCountryDTO);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(null)]
        public void GetModelFromDTO_WhenInvaildTestPassed_ShouldReturnArgumentNullException(UserDTO countryModel)
        {
            Assert.Throws<ArgumentNullException>(() => _userModelMapper.GetModelFromDTO(countryModel));
        }

        [TestCaseSource(typeof(GetDTOFromModelSource))]
        public void GetDTOFromModel_WhenValidTestPassed(UserModel userModel, UserDTO expected)
        {
            UserDTO actual = _userModelMapper.GetDTOFromModel(userModel);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(null)]
        public void GetCountryDTOFromCountryModel_WhenInvaildTestPassed_ShouldReturnArgumentNullException(UserModel userModel)
        {
            Assert.Throws<ArgumentNullException>(() => _userModelMapper.GetDTOFromModel(userModel));
        }
    }
}
