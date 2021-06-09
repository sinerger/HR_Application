
using HR_Application_BLL.Mappers;
using HR_Application_BLL.Models;
using HR_Application_BLL.Tests.Souces;
using HR_Application_DB_Logic.Models;
using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace HR_Application_BLL.Tests.TestsClases
{
    public class EmployeeSkillMapperTests
    {
        private EmployeeSkillMapper _employeeSkillMapper;

        [SetUp]
        public void Setup()
        {
            _employeeSkillMapper = new EmployeeSkillMapper();
        }

        [TestCaseSource(typeof(GetModelsFromDTOSource))]
        public void GetModelsFromDTO_WhenValidTestPassed_ShouldReturnListLocationModels(List<EmployeeSkillDTO> actualEmployeeSkillDTO, List<EmployeeSkillModel> expected)
        {
            List<EmployeeSkillModel> actual = _employeeSkillMapper.GetModelsFromDTO(actualEmployeeSkillDTO);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(null)]
        public void GetModelsFromDTO_WhenInvaildTestPassed_ShouldReturnArgumentNullException(List<HR_Application_DB_Logic.Models.Custom.EmployeeSkillDTO> employeeSkillModel)
        {
            Assert.Throws<ArgumentNullException>(() => _employeeSkillMapper.GetModelsFromDTO(employeeSkillModel));
        }

        [TestCaseSource(typeof(GetDTOFromModelSource))]
        public void GetDTOFromModel_WhenValidTestPassed_ShouldReturnLocationDTO(EmployeeSkillModel employeeSkillModel, EmployeeSkillDTO expected)
        {
            HR_Application_DB_Logic.Models.Custom.EmployeeSkillDTO actual = _employeeSkillMapper.GetDTOFromModel(employeeSkillModel);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(null)]
        public void GetDTOFromModel_WhenInvaildTestPassed_ShouldReturnArgumentNullException(EmployeeSkillModel employeeSkillModel)
        {
            Assert.Throws<ArgumentNullException>(() => _employeeSkillMapper.GetDTOFromModel(employeeSkillModel));
        }

        [TestCaseSource(typeof(GetModelFromDTOSource))]
        public void GetModelsFromDTO_WhenInvaildTestPassed_ShouldReturnLocationModelByID(EmployeeSkillDTO actualEmployeeSkillDTO, EmployeeSkillModel expected)
        {
            EmployeeSkillModel actual = _employeeSkillMapper.GetModelFromDTO(actualEmployeeSkillDTO);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(null)]
        public void GetModelFromDTO_WhenInvaildTestPassed_ShouldReturnArgumentNullException(EmployeeSkillDTO employeeSkillDTO)
        {
            Assert.Throws<ArgumentNullException>(() => _employeeSkillMapper.GetModelFromDTO(employeeSkillDTO));
        }

    }
}
