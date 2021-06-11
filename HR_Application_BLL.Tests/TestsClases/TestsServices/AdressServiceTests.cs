using System;
using System.Collections.Generic;
using System.Text;
using HR_Application_BLL.Models;
using HR_Application_BLL.Services;
using HR_Application_BLL.Tests.Souces.AdressServiceSources;
using HR_Application_DB_Logic.Interfaces;
using HR_Application_DB_Logic.Models;
using Moq;
using NUnit.Framework;

namespace HR_Application_BLL.Tests.TestsClases.TestsServices
{
    public class AdressServiceTests
    {
        private Mock<IDBController> _mock;
        private AdressService _adressService;

        [SetUp]
        public void Setup()
        {
            _mock = new Mock<IDBController>();
            _adressService = new AdressService(_mock.Object);
        }

        [TestCaseSource(typeof(AdressServicesGetAllSoruce))]
        public void GetAll_WhenValidTestPassed_ShouldReturnListAdresses(List<LocationDTO> returnedLocationsDTO,
            List<CityDTO> returnedCitiesDTO, List<CountryDTO> returedCountriesDTO, List<Adress> expected)
        {
            _mock.Setup(dbController => dbController.LocationRepository.GetAll()).Returns(returnedLocationsDTO);
            _mock.Setup(dbController => dbController.CityRepository.GetAll()).Returns(returnedCitiesDTO);
            _mock.Setup(dbController => dbController.CountryRepository.GetAll()).Returns(returedCountriesDTO);

            var actual = _adressService.GetAll();

            Assert.AreEqual(expected, actual);
        }

        [TestCaseSource(typeof(AdressServiceGetByIDCource))]
        public void GetByID_WhenValidTestPassed_ShouldReturnAdressIbject(int id,LocationDTO returnedLocationDTO,
            CityDTO returnedCitryDTO, CountryDTO returnedCountryDTO, Adress expected)
        {
            _mock.Setup(dbController => dbController.LocationRepository.GetByID(id)).Returns(returnedLocationDTO);
            _mock.Setup(dbController => dbController.CityRepository.GetByID(id)).Returns(returnedCitryDTO);
            _mock.Setup(dbController => dbController.CountryRepository.GetByID(id)).Returns(returnedCountryDTO);

            var actual = _adressService.GetByID(id);

            Assert.AreEqual(expected, actual);
        }
    }
}
