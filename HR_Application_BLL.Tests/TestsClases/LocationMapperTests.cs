using HR_Application_BLL.Mappers.Base;
using HR_Application_BLL.Models.Base;
using HR_Application_BLL.Tests.Souces.Location;
using HR_Application_DB_Logic.Interfaces;
using HR_Application_DB_Logic.Models;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace HR_Application_BLL.Tests.TestsClases
{
    public class LocationMapperTests
    {
        private Mock<IDBController> _mock;
        private LocationMapper _locationMapper;

        [SetUp]
        public void Setup()
        {
            _mock = new Mock<IDBController>();
            _locationMapper = new LocationMapper(_mock.Object);
        }

        [TestCaseSource(typeof(GetAllLocationModelsFromLocationDTOSource))]
        public void GetAllLocationModelsFromLocationDTO_WhenValidTestPassed_ShouldReturnListLocationModels(List<LocationDTO> returnedLocationsDTO, List<LocationModel> expected)
        {
            _mock.Setup(dbController => (dbController.LocationRepository.GetAll())).Returns(returnedLocationsDTO);

            List<LocationModel> actual = _locationMapper.GetAllModelsFromDTO();

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GetAllLocationModelsFromLocationDTO_WhenInvalidTestPassed_ShouldReturnArgumentNullException()
        {
            _mock.Setup(dbController => (dbController.LocationRepository.GetAll())).Throws(new ArgumentNullException());

            Assert.Throws<ArgumentNullException>(() => _locationMapper.GetAllModelsFromDTO());
        }

        [TestCaseSource(typeof(GetLocationDTOFromLocationModelSource))]
        public void GetLocationDTOFromLocationModel_WhenValidTestPassed(LocationModel locationModel, LocationDTO expected)
        {
            LocationDTO actual = _locationMapper.GetDTOFromModel(locationModel);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(null)]
        public void GetLocationDTOFromLocationModel_WhenInvaildTestPassed_ShouldReturnArgumentNullException(LocationModel locationModel)
        {
            Assert.Throws<ArgumentNullException>(() => _locationMapper.GetDTOFromModel(locationModel));
        }

        [TestCaseSource(typeof(GetLocationModelsFromLocationDTOByIDSource))]
        public void GetLocationModelsFromLocationDTOByID_WhenInvaildTestPassed_ShouldReturnLocationModelByID(int id, LocationDTO returnedLocationDTO, LocationModel expected)
        {
            _mock.Setup(dbController => (dbController.LocationRepository.GetByID(id))).Returns(returnedLocationDTO);

            LocationModel actual = _locationMapper.GetLocationModelsFromLocationDTOByID(id);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(1)]
        public void GetLocationModelsFromLocationDTOByID_WhenInvalidTestPassed_ShouldReturnArgumentNullException(int id )
        {
            _mock.Setup(dbController => (dbController.LocationRepository.GetByID(id))).Throws(new ArgumentNullException());

            Assert.Throws<ArgumentNullException>(() => _locationMapper.GetLocationModelsFromLocationDTOByID(id));
        }

        [TestCase(-100)]
        [TestCase(-10)]
        [TestCase(-1)]
        public void GetLocationModelsFromLocationDTOByID_WhenInvalidTestPassed_ShouldReturnArgumentException(int id)
        {
            _mock.Setup(dbController => (dbController.LocationRepository.GetByID(id))).Throws(new ArgumentException());

            Assert.Throws<ArgumentException>(() => _locationMapper.GetLocationModelsFromLocationDTOByID(id));
        }
    }
}
