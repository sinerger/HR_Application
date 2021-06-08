using HR_Application_BLL.Mappers.Base;
using HR_Application_BLL.Models.Base;
using HR_Application_BLL.Tests.Souces.Location;
using HR_Application_DB_Logic.Models;
using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace HR_Application_BLL.Tests.TestsClases
{
    public class LocationMapperTests
    {
        private LocationMapper _locationMapper;

        [SetUp]
        public void Setup()
        {
            _locationMapper = new LocationMapper();
        }

        [TestCaseSource(typeof(GetModelsFromDTOSource))]
        public void GetModelsFromDTO_WhenValidTestPassed_ShouldReturnListLocationModels(List<LocationDTO> actualLocationsDTO, List<LocationModel> expected)
        {
            List<LocationModel> actual = _locationMapper.GetModelsFromDTO(actualLocationsDTO);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(null)]
        public void GetModelsFromDTO_WhenInvaildTestPassed_ShouldReturnArgumentNullException(List<LocationDTO> locationsModel)
        {
            Assert.Throws<ArgumentNullException>(() => _locationMapper.GetModelsFromDTO(locationsModel));
        }

        [TestCaseSource(typeof(GetDTOFromModelSource))]
        public void GetDTOFromModel_WhenValidTestPassed_ShouldReturnLocationDTO(LocationModel locationModel, LocationDTO expected)
        {
            LocationDTO actual = _locationMapper.GetDTOFromModel(locationModel);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(null)]
        public void GetDTOFromModel_WhenInvaildTestPassed_ShouldReturnArgumentNullException(LocationModel locationModel)
        {
            Assert.Throws<ArgumentNullException>(() => _locationMapper.GetDTOFromModel(locationModel));
        }

        [TestCaseSource(typeof(GetModelFromDTOSource))]
        public void GetModelsFromDTO_WhenInvaildTestPassed_ShouldReturnLocationModelByID( LocationDTO actualLocationDTO, LocationModel expected)
        {
            LocationModel actual = _locationMapper.GetModelFromDTO(actualLocationDTO);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(null)]
        public void GetModelFromDTO_WhenInvaildTestPassed_ShouldReturnArgumentNullException(LocationDTO locationDTO)
        {
            Assert.Throws<ArgumentNullException>(() => _locationMapper.GetModelFromDTO(locationDTO));
        }
    }
}
