using HR_Application_BLL.Mappers;
using HR_Application_BLL.Models;
using HR_Application_BLL.Tests.Souces.AdressSources;
using HR_Application_DB_Logic.Models;
using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace HR_Application_BLL.Tests.TestsClases
{
    public class AdressMapperTests
    {
        private AdressMapper _adressMapper;

        [SetUp]
        public void Setup()
        {
            _adressMapper = new AdressMapper();
        }

        [TestCaseSource(typeof(GetModelsFromDTOSource))]
        public void GetModelsFromDTO_WhenValidTestPassed_ShouldReturnListAdressesModel(List<LocationDTO> locationsDTO,
            List<CityDTO> citiesDTO, List<CountryDTO> countiresDTO, List<Adress> expected)
        {
            List<Adress> actual = _adressMapper.GetModelsFromDTO(locationsDTO, citiesDTO, countiresDTO);

            Assert.AreEqual(expected, actual);
        }

        [TestCaseSource(typeof(GetModelFromDTOSource))]
        public void GetModelFromDTO_WhenValidTestPassed_ShouldReturnAdressModelObj(LocationDTO locationDTO,
            CityDTO cityDTO,CountryDTO countryDTO ,Adress expected)
        {
            Adress actual = _adressMapper.GetModelFromDTO(locationDTO, cityDTO, countryDTO);

            Assert.AreEqual(expected, actual);
        }
    }
}
