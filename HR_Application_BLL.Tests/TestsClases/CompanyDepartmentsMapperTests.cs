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

        [TestCaseSource(typeof(GetModelsFromDTOSource))]
        public void GetModelsFromDTO_WhenValidTestPassed_ShouldReturnListCompanyDepartmentsModels(List<CompanyDepartmentsDTO> actualCompaniesDepartmentsDTO, List<CompanyDepartmentsModel> expected)
        {
            List<CompanyDepartmentsModel> actual = _companyDepartmentsMapper.GetModelsFromDTO(actualCompaniesDepartmentsDTO);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(null)]
        public void GetModelsFromDTO_WhenInvaildTestPassed_ShouldReturnArgumentNullException(List<CompanyDepartmentsDTO> companiesDepartmentsModel)
        {
            Assert.Throws<ArgumentNullException>(() => _companyDepartmentsMapper.GetModelsFromDTO(companiesDepartmentsModel));
        }

        [TestCaseSource(typeof(GetDTOFromModelSource))]
        public void GetDTOFromModel_WhenValidTestPassed_ShouldReturnCompanyDTO(CompanyDepartmentsModel companyDepartmentsModel, CompanyDepartmentsDTO expected)
        {
            CompanyDepartmentsDTO actual = _companyDepartmentsMapper.GetDTOFromModel(companyDepartmentsModel);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(null)]
        public void GetDTOFromModel_WhenInvaildTestPassed_ShouldReturnArgumentNullException(CompanyDepartmentsModel companyDepartmentsModel)
        {
            Assert.Throws<ArgumentNullException>(() => _companyDepartmentsMapper.GetDTOFromModel(companyDepartmentsModel));
        }

        [TestCaseSource(typeof(GetModelFromDTOSources))]
        public void GetModelFromDTO_WhenValidTestPassed_ShouldReturnCompanyDepartmentsModel(CompanyDepartmentsDTO companyDepartmentsDTO,
            CompanyDepartmentsModel expected)
        {
            var actual = _companyDepartmentsMapper.GetModelFromDTO(companyDepartmentsDTO);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(null)]
        public void GetModelFromDTO_WhenInvaildTestPassed_ShouldReturnArgumentNullException(CompanyDepartmentsDTO companyDepartmentsDTO)
        {
            Assert.Throws<ArgumentNullException>(() => _companyDepartmentsMapper.GetModelFromDTO(companyDepartmentsDTO));
        }
    }
}