using HR_Application_BLL.Mappers.Base;
using HR_Application_BLL.Models.Base;
using HR_Application_BLL.Tests.Souces.CompanyDepartmentsSource;
using HR_Application_DB_Logic.Models.Base;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace HR_Application_BLL.Tests.TestsClases
{
    public class CompanyDepartmentsMapperTests
    {
        private CompanyDepartmentsMapper _companyDepartmentsMapper;

        [SetUp]
        public void Setup()
        {
            _companyDepartmentsMapper = new CompanyDepartmentsMapper();
        }

        [TestCaseSource(typeof(GetModelFromDTOSources))]
        public void GetModelFromDTO_WhenValidTestPassed_ShouldReturnCompanyDepartmentsModel(CompanyDepartmentsDTO companyDepartmentsDTO,
            CompanyDepartmentsModel expected)
        {
            var actual = _companyDepartmentsMapper.GetModelFromDTO(companyDepartmentsDTO);

            Assert.AreEqual(expected, actual);
        }
    }
}