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

        [TestCaseSource(typeof(DepartmentProjectsGetModelFromDTOSources))]
        public void GetModelFromDTO_WhenValidTestPassed_ShouldReturndepartmentProjectsModel(DepartmentProjectsDTO departmentProjectsDTO, 
            DepartmentProjectsModel expected)
        {
            var actual = _departmentProjectsMapper.GetModelFromDTO(departmentProjectsDTO);

            Assert.AreEqual(expected, actual);
        }
    }
}
