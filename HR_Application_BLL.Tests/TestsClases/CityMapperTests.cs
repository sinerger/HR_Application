using HR_Application_BLL.Mappers.Base;
using HR_Application_BLL.Models.Base;
using HR_Application_BLL.Tests.Souces.City;
using HR_Application_DB_Logic.Interfaces;
using HR_Application_DB_Logic.Models;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace HR_Application_BLL.Tests.TestsClases
{
    public class CityMapperTests
    {
        private Mock<IDBController> _mock;
        private CityMapper _cityMapper;

        [SetUp]
        public void Setup()
        {
            _mock = new Mock<IDBController>();
            _cityMapper = new CityMapper(_mock.Object);
        }

        [TestCaseSource(typeof(GetAllCityModelFromSityDTOSource))]
        public void GetAllCityModelFromCityDTO_WhenValidTestPassed_ShouldReturnListCityModels(List<CityDTO> returnedCityDTO, List<CityModel> expected)
        {
            _mock.Setup(dbController => (dbController.CityRepository.GetAll())).Returns(returnedCityDTO);

            List<CityModel> actual = _cityMapper.GetAllModelFromDTO();

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GetAllCityModelFromCityDTO_WhenInalidTestPassed_ShouldReturnArgumentNullException()
        {
            _mock.Setup(dbController => (dbController.CityRepository.GetAll())).Throws(new ArgumentNullException());

            Assert.Throws<ArgumentNullException>(() => _cityMapper.GetAllModelFromDTO());
        }

        [TestCaseSource(typeof(GetCityModelFromCityDTOByIDSource))]
        public void GetCityModelFromCityDTOByID_WhenValidTestPassed_ShouldReturnCityModelByID(int id,CityDTO returnedCityDTO, CityModel expected)
        {
            _mock.Setup(dbController => (dbController.CityRepository.GetByID(id))).Returns(returnedCityDTO);

            CityModel actual = _cityMapper.GetModelFromDTOByID(id);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(1)]
        public void GetCityModelFromCityDTOByID_WhenInvalidTestPassed_ShouldReturnArgumentNullException(int id)
        {
            _mock.Setup(dbController => (dbController.CityRepository.GetByID(id))).Throws(new ArgumentNullException());

            Assert.Throws<ArgumentNullException>(() => _cityMapper.GetModelFromDTOByID(id));
        }

        [TestCase(-100)]
        [TestCase(-10)]
        [TestCase(-1)]
        public void GetCityModelFromCityDTOByID_WhenInvalidTestPassed_ShouldReturnArgumentException(int id)
        {
            _mock.Setup(dbController => (dbController.CityRepository.GetByID(id))).Throws(new ArgumentException());

            Assert.Throws<ArgumentException>(() => _cityMapper.GetModelFromDTOByID(id));
        }

        [TestCaseSource(typeof(GetCityDTOFromCityModelSource))]
        public void GetLocationDTOFromLocationModel_WhenValidTestPassed(CityModel cityModel, CityDTO expected)
        {
            CityDTO actual = _cityMapper.GetDTOFromModel(cityModel);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(null)]
        public void GetCityDTOFromCityModel_WhenInvaildTestPassed_ShouldReturnArgumentNullException(CityModel cityModel)
        {
            Assert.Throws<ArgumentNullException>(() => _cityMapper.GetDTOFromModel(cityModel));
        }
    }
}
