using HR_Application_BLL.Mappers.Base;
using HR_Application_BLL.Models.Base;
using HR_Application_BLL.Tests.Souces.Employee;
using HR_Application_DB_Logic.Models;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace HR_Application_BLL.Tests.TestsClases
{
    public class EmployeeMapperTests
    {
        private EmployeeMapper _employeeMapper;

        [SetUp]
        public void SetUp()
        {
            _employeeMapper = new EmployeeMapper();
        }

        [TestCaseSource(typeof(GetModelsFromDTOSource))]
        public void GetModelsFromDTO_WhenValidTestPassed_ShouldReturnListEmployeeModels(List<EmployeeDTO> actualEmployeeDTO, List<EmployeeModel> expected)
        {
            List<EmployeeModel> actual = _employeeMapper.GetModelsFromDTO(actualEmployeeDTO);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(null)]
        public void GetModelsFromDTO_WhenInvaildTestPassed_ShouldReturnArgumentException(List<EmployeeDTO> employeeDTOs)
        {
            Assert.Throws<ArgumentException>(() => _employeeMapper.GetModelsFromDTO(employeeDTOs));
        }

        [TestCaseSource(typeof(GetDTOFromModel))]
        public void GetDTOFromModel_WhenValidTestPassed_ShouldReturnEmployeeDTO(EmployeeModel employeeModel, EmployeeDTO expected)
        {
            EmployeeDTO actual = _employeeMapper.GetDTOFromModel(employeeModel);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(null)]
        public void GetDTOFromModel_WhenInvaildTestPassed_ShouldReturnArgumentException(EmployeeModel employeeModel)
        {
            Assert.Throws<ArgumentException>(() => _employeeMapper.GetDTOFromModel(employeeModel));
        }

        [TestCaseSource(typeof(GetModelFromDTOSource))]
        public void GetModelsFromDTO_WhenInvaildTestPassed_ShouldReturnEmployeeModel(EmployeeDTO actualEmployeeDTO, EmployeeModel expected)
        {
            EmployeeModel actual = _employeeMapper.GetModelFromDTO(actualEmployeeDTO);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(null)]
        public void GetModelFromDTO_WhenInvaildTestPassed_ShouldReturnArgumentNullException(EmployeeDTO employeeDTO)
        {
            Assert.Throws<ArgumentException>(() => _employeeMapper.GetModelFromDTO(employeeDTO));
        }




    }
}
