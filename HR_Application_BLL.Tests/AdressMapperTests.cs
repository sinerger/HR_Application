using HR_Application_BLL.Controllers;
using HR_Application_BLL.Mappers;
using HR_Application_BLL.Models;
using HR_Application_BLL.Tests.Souces;
using HR_Application_DB_Logic.Interfaces;
using HR_Application_DB_Logic.Models;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace HR_Application_BLL.Tests
{
    public class AdressMapperTests
    {
        private Mock<IDBController> _mock;
        private AdressMapper _adressMapper;

        [SetUp]
        public void Setup()
        {
            _mock = new Mock<IDBController>();
            _adressMapper = new AdressMapper(_mock.Object);
        }

        [TestCaseSource(typeof(GetAllAdressesFromAdressDTOSources))]
        public void GetAllAdressesFromAdressDTO_WhenValidTestPassed_ShouldReturnListAdesses(List<AdressDTO> returnedAdressesDTO, List<Adress> expected)
        {
            _mock.Setup(getAll => (getAll.AdressRepository.GetAll())).Returns(returnedAdressesDTO);
            List<Adress> actual = _adressMapper.GetAllAdressesFromAdressDTO();

            Assert.AreEqual(expected, actual);
        }
    }
}
