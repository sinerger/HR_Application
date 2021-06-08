using HR_Application_BLL.Mappers.Base;
using HR_Application_BLL.Models.Base;
using HR_Application_BLL.Tests.Souces.City;
using HR_Application_BLL.Tests.Souces.Country;
using HR_Application_DB_Logic.Interfaces;
using HR_Application_DB_Logic.Models;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace HR_Application_BLL.Tests.TestsClases
{
    public class CounryMapperTests
    {
        private Mock<IDBController> _mock;
        private CountryMapper _countryMapper;

        [SetUp]
        public void Setup()
        {
            _mock = new Mock<IDBController>();
            _countryMapper = new CountryMapper(_mock.Object);
        }

        [TestCaseSource(typeof(GetAllCountryModelFromCountryDTOSource))]
        public void GetAllCountryModelFromCountryDTO_WhenValidTestPassed_ShouldReturnListCountryModels(List<CountryDTO> returnedDTO, List<CountryModel> expected)
        {
            _mock.Setup(dbController => (dbController.CountryRepository.GetAll())).Returns(returnedDTO);

            List<CountryModel> actual = _countryMapper.GetAllModelsFromDTO();

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GetAllCountryModelFromCountryDTO_WhenInalidTestPassed_ShouldReturnArgumentNullException()
        {
            _mock.Setup(dbController => (dbController.CountryRepository.GetAll())).Throws(new ArgumentNullException());

            Assert.Throws<ArgumentNullException>(() => _countryMapper.GetAllModelsFromDTO());
        }

        [TestCaseSource(typeof(GetCountryModelFromCountryDTOByIDSource))]
        public void GetCountryModelFromCountryDTOByID_WhenValidTestPassed_ShouldReturnCountryModelByID(int id, CountryDTO returnedDTO, CountryModel expected)
        {
            _mock.Setup(dbController => (dbController.CountryRepository.GetByID(id))).Returns(returnedDTO);

            CountryModel actual = _countryMapper.GetCountryModelFromCountryDTOByID(id);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(1)]
        public void GetCountryModelFromCountryDTOByID_WhenInvalidTestPassed_ShouldReturnArgumentNullException(int id)
        {
            _mock.Setup(dbController => (dbController.CountryRepository.GetByID(id))).Throws(new ArgumentNullException());

            Assert.Throws<ArgumentNullException>(() => _countryMapper.GetCountryModelFromCountryDTOByID(id));
        }

        [TestCase(-100)]
        [TestCase(-10)]
        [TestCase(-1)]
        public void GetCountryModelFromCountryDTOByID_WhenInvalidTestPassed_ShouldReturnArgumentException(int id)
        {
            _mock.Setup(dbController => (dbController.CountryRepository.GetByID(id))).Throws(new ArgumentException());

            Assert.Throws<ArgumentException>(() => _countryMapper.GetCountryModelFromCountryDTOByID(id));
        }

        [TestCaseSource(typeof(GetCountryDTOFromCountryModelSources))]
        public void GetCountryDTOFromCountryModel_WhenValidTestPassed(CountryModel countryModel, CountryDTO expected)
        {
            CountryDTO actual = _countryMapper.GetCountryDTOFromCountryModel(countryModel);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(null)]
        public void GetCountryDTOFromCountryModel_WhenInvaildTestPassed_ShouldReturnArgumentNullException(CountryModel countryModel)
        {
            Assert.Throws<ArgumentNullException>(() => _countryMapper.GetCountryDTOFromCountryModel(countryModel));
        }
    }
}
