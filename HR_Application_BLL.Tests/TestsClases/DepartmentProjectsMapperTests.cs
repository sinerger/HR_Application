using HR_Application_BLL.Mappers.Base;
using HR_Application_BLL.Models.Base;
using HR_Application_BLL.Tests.Souces.DepartmentProjectsSources;
using HR_Application_DB_Logic.Models.Base;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace HR_Application_BLL.Tests.TestsClases
{
    public class DepartmentProjectsMapperTests
    {
        private DepartmentProjectsMapper _departmentProjectsMapper;

        [SetUp]
        public void Setup()
        {
            _departmentProjectsMapper = new DepartmentProjectsMapper();
        }

        [TestCaseSource(typeof(GetModelsFromDTOSource))]
        public void GetModelsFromDTO_WhenValidTestPassed_ShouldReturnListDepartmentProjectsModels(List<DepartmentProjectsDTO> actualDepartmentsProjectsDTO, List<DepartmentProjectsModel> expected)
        {
            List<DepartmentProjectsModel> actual = _departmentProjectsMapper.GetModelsFromDTO(actualDepartmentsProjectsDTO);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(null)]
        public void GetModelsFromDTO_WhenInvaildTestPassed_ShouldReturnArgumentNullException(List<DepartmentProjectsDTO> departmentProjectsModel)
        {
            Assert.Throws<ArgumentNullException>(() => _departmentProjectsMapper.GetModelsFromDTO(departmentProjectsModel));
        }

        [TestCaseSource(typeof(GetDTOFromModelSource))]
        public void GetDTOFromModel_WhenValidTestPassed_ShouldReturnDepartmentProjectsDTO(DepartmentProjectsModel departmentProjectsModel, DepartmentProjectsDTO expected)
        {
            DepartmentProjectsDTO actual = _departmentProjectsMapper.GetDTOFromModel(departmentProjectsModel);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(null)]
        public void GetDTOFromModel_WhenInvaildTestPassed_ShouldReturnArgumentNullException(DepartmentProjectsModel departmentProjectsModel)
        {
            Assert.Throws<ArgumentNullException>(() => _departmentProjectsMapper.GetDTOFromModel(departmentProjectsModel));
        }

        [TestCaseSource(typeof(GetModelFromDTOSources))]
        public void GetModelFromDTO_WhenValidTestPassed_ShouldReturndepartmentProjectsModel(DepartmentProjectsDTO departmentProjectsDTO, 
            DepartmentProjectsModel expected)
        {
            var actual = _departmentProjectsMapper.GetModelFromDTO(departmentProjectsDTO);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(null)]
        public void GetModelFromDTO_WhenInvaildTestPassed_ShouldReturnArgumentNullException(DepartmentProjectsDTO departmentProjectsDTO)
        {
            Assert.Throws<ArgumentNullException>(() => _departmentProjectsMapper.GetModelFromDTO(departmentProjectsDTO));
        }
    }
}
