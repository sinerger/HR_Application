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
        private CityMapper _cityMapper;

        [SetUp]
        public void Setup()
        {
            _cityMapper = new CityMapper();
        }

        [TestCaseSource(typeof(GetModelsFromDTOSource))]
        public void GetModelsFromDTO_WhenValidTestPassed_ShouldReturnListCityModels(List<CityDTO> actualListCityDTO, List<CityModel> expected)
        {
            List<CityModel> actual = _cityMapper.GetModelsFromDTO(actualListCityDTO);

            Assert.AreEqual(expected, actual);
        }

        [TestCaseSource(typeof(GetModelFromDTOSource))]
        public void GetModelFromDTO_WhenValidTestPassed_ShouldReturnCityModelByID(CityDTO actualCityDTO, CityModel expected)
        {
            CityModel actual = _cityMapper.GetModelFromDTO(actualCityDTO);

            Assert.AreEqual(expected, actual);
        }

        [TestCaseSource(typeof(GetDTOFromModelSource))]
        public void GetDTOFromModel_WhenValidTestPassed(CityModel cityModel, CityDTO expected)
        {
            CityDTO actual = _cityMapper.GetDTOFromModel(cityModel);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(null)]
        public void GetDTOFromModel_WhenInvaildTestPassed_ShouldReturnArgumentNullException(CityModel cityModel)
        {
            Assert.Throws<ArgumentNullException>(() => _cityMapper.GetDTOFromModel(cityModel));
        }
    }
}
