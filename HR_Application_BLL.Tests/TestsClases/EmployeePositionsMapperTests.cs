using HR_Application_BLL.Mappers;
using HR_Application_DB_Logic.Models;
using HR_Application_BLL.Tests.Souces.EmploeePosition;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using HR_Application_BLL.Base.Models;

namespace HR_Application_BLL.Tests.TestsClases
{
    class EmployeePositionsMapperTests
    {
        private EmployeePositionModelMapper _employeePositionModelMapper;

        [SetUp]
        public void Setup()
        {
            _employeePositionModelMapper = new EmployeePositionModelMapper();
        }

        [TestCaseSource(typeof(GetModelsFromDTOSource))]
        public void GetModelsFromDTO_WhenValidTestPassed_ShouldReturnListEmployeePositionModels(List<EmployeePositionDTO> actualEmployeePositionsDTO, List<EmployeePositionModel> expected)
        {
            List<EmployeePositionModel> actual = _employeePositionModelMapper.GetModelsFromDTO(actualEmployeePositionsDTO);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(null)]
        public void GetModelsFromDTO_WhenInvaildTestPassed_ShouldReturnArgumentNullException(List<EmployeePositionDTO> employeePositionModel)
        {
            Assert.Throws<ArgumentNullException>(() => _employeePositionModelMapper.GetModelsFromDTO(employeePositionModel));
        }

        [TestCaseSource(typeof(GetModelFromDTOSource))]
        public void GetModelFromDTO_WhenValidTestPassed_ShouldReturnEmployeePositionModelByID(EmployeePositionDTO actualEmployeePositionDTO, EmployeePositionModel expected)
        {
            EmployeePositionModel actual = _employeePositionModelMapper.GetModelFromDTO(actualEmployeePositionDTO);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(null)]
        public void GetModelFromDTO_WhenInvaildTestPassed_ShouldReturnArgumentNullException(EmployeePositionDTO employeePositionModel)
        {
            Assert.Throws<ArgumentNullException>(() => _employeePositionModelMapper.GetModelFromDTO(employeePositionModel));
        }

        [TestCaseSource(typeof(GetDTOFromModelSource))]
        public void GetDTOFromModel_WhenValidTestPassed(EmployeePositionModel employeePositionModel, EmployeePositionDTO expected)
        {
            EmployeePositionDTO actual = _employeePositionModelMapper.GetDTOFromModel(employeePositionModel);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(null)]
        public void GetCountryDTOFromCountryModel_WhenInvaildTestPassed_ShouldReturnArgumentNullException(EmployeePositionModel employeePositionModel)
        {
            Assert.Throws<ArgumentNullException>(() => _employeePositionModelMapper.GetDTOFromModel(employeePositionModel));
        }
    }
}
