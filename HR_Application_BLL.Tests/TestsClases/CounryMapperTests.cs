using HR_Application_BLL.Mappers.Base;
using HR_Application_BLL.Models.Base;
using HR_Application_BLL.Tests.Souces.Country;
using HR_Application_DB_Logic.Models;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace HR_Application_BLL.Tests.TestsClases
{
    public class CounryMapperTests
    {
        private CountryMapper _countryMapper;

        [SetUp]
        public void Setup()
        {
            _countryMapper = new CountryMapper();
        }

        [TestCaseSource(typeof(GetModelsFromDTOSource))]
        public void GetModelsFromDTO_WhenValidTestPassed_ShouldReturnListCountryModels(List<CountryDTO> actualCountiesDTO, List<CountryModel> expected)
        {
            List<CountryModel> actual = _countryMapper.GetModelsFromDTO(actualCountiesDTO);

            Assert.AreEqual(expected, actual);
        }
        [TestCase(null)]
        public void GetModelsFromDTO_WhenInvaildTestPassed_ShouldReturnArgumentNullException(List<CountryDTO> countryModel)
        {
            Assert.Throws<ArgumentNullException>(() => _countryMapper.GetModelsFromDTO(countryModel));
        }

        [TestCaseSource(typeof(GetModelFromDTOSource))]
        public void GetModelFromDTO_WhenValidTestPassed_ShouldReturnCountryModelByID( CountryDTO actualCountryDTO, CountryModel expected)
        {
            CountryModel actual = _countryMapper.GetModelFromDTO(actualCountryDTO);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(null)]
        public void GetModelFromDTO_WhenInvaildTestPassed_ShouldReturnArgumentNullException(CountryDTO countryModel)
        {
            Assert.Throws<ArgumentNullException>(() => _countryMapper.GetModelFromDTO(countryModel));
        }

        [TestCaseSource(typeof(GetDTOFromModelSources))]
        public void GetDTOFromModel_WhenValidTestPassed(CountryModel countryModel, CountryDTO expected)
        {
            CountryDTO actual = _countryMapper.GetDTOFromModel(countryModel);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(null)]
        public void GetCountryDTOFromCountryModel_WhenInvaildTestPassed_ShouldReturnArgumentNullException(CountryModel countryModel)
        {
            Assert.Throws<ArgumentNullException>(() => _countryMapper.GetDTOFromModel(countryModel));
        }
    }
}
