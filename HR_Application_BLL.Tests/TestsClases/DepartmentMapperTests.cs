using HR_Application_BLL.Models.Base;
using HR_Application_BLL.Mappers.Base;
using HR_Application_BLL.Tests.Souces.Department;
using HR_Application_DB_Logic.Models;
using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace HR_Application_BLL.Tests.TestsClases
{
    public class DepartmentMapperTests
    {
        private DepartmentMapper _departmentMapper;

        [SetUp]
        public void Setup()
        {
            _departmentMapper = new DepartmentMapper();
        }

        [TestCaseSource(typeof(GetModelsFromDTOSource))]
        public void GetModelsFromDTO_WhenValidTestPassed_ShouldReturnListLocationModels(List<DepartmentDTO> actualDepartmentDTO, List<DepartmentModel> expected)
        {
            List<DepartmentModel> actual = _departmentMapper.GetModelsFromDTO(actualDepartmentDTO);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(null)]
        public void GetModelsFromDTO_WhenInvaildTestPassed_ShouldReturnArgumentNullException(List<DepartmentDTO> departmentsModel)
        {
            Assert.Throws<ArgumentNullException>(() => _departmentMapper.GetModelsFromDTO(departmentsModel));
        }

        [TestCaseSource(typeof(GetDTOFromModelSource))]
        public void GetDTOFromModel_WhenValidTestPassed_ShouldReturnLocationDTO(DepartmentModel departmentModel, DepartmentDTO expected)
        {
            DepartmentDTO actual = _departmentMapper.GetDTOFromModel(departmentModel);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(null)]
        public void GetDTOFromModel_WhenInvaildTestPassed_ShouldReturnArgumentNullException(DepartmentModel departmentModel)
        {
            Assert.Throws<ArgumentNullException>(() => _departmentMapper.GetDTOFromModel(departmentModel));
        }

        [TestCaseSource(typeof(GetModelFromDTOSource))]
        public void GetModelsFromDTO_WhenInvaildTestPassed_ShouldReturnLocationModelByID(DepartmentDTO actualDepartmentDTO, DepartmentModel expected)
        {
            DepartmentModel actual = _departmentMapper.GetModelFromDTO(actualDepartmentDTO);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(null)]
        public void GetModelFromDTO_WhenInvaildTestPassed_ShouldReturnArgumentNullException(DepartmentDTO departmentDTO)
        {
            Assert.Throws<ArgumentNullException>(() => _departmentMapper.GetModelFromDTO(departmentDTO));
        }
    }
}
