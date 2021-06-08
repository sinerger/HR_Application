using HR_Application_BLL.Mappers.Base;
using HR_Application_BLL.Models.Base;
using HR_Application_DB_Logic.Models;
using HR_Application_BLL.Tests.Souces.Company;
using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace HR_Application_BLL.Tests.TestsClases
{
    public class CompanyMapperTests
    {
        private CompanyMapper _companyMapper;

        [SetUp]
        public void Setup()
        {
            _companyMapper = new CompanyMapper();
        }

        [TestCaseSource(typeof(GetModelsFromDTOSource))]
        public void GetModelsFromDTO_WhenValidTestPassed_ShouldReturnListCompanyModels(List<CompanyDTO> actualCompaniesDTO, List<CompanyModel> expected)
        {
            List<CompanyModel> actual = _companyMapper.GetModelsFromDTO(actualCompaniesDTO);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(null)]
        public void GetModelsFromDTO_WhenInvaildTestPassed_ShouldReturnArgumentNullException(List<CompanyDTO> companiesModel)
        {
            Assert.Throws<ArgumentNullException>(() => _companyMapper.GetModelsFromDTO(companiesModel));
        }

        [TestCaseSource(typeof(GetDTOFromModelSource))]
        public void GetDTOFromModel_WhenValidTestPassed_ShouldReturnCompanyDTO(CompanyModel companyModel, CompanyDTO expected)
        {
            CompanyDTO actual = _companyMapper.GetDTOFromModel(companyModel);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(null)]
        public void GetDTOFromModel_WhenInvaildTestPassed_ShouldReturnArgumentNullException(CompanyModel companyModel)
        {
            Assert.Throws<ArgumentNullException>(() => _companyMapper.GetDTOFromModel(companyModel));
        }

        [TestCaseSource(typeof(GetModelFromDTOSource))]
        public void GetModelsFromDTO_WhenInvaildTestPassed_ShouldReturnCompanyModelByID(CompanyDTO actualCompanyDTO, CompanyModel expected)
        {
            CompanyModel actual = _companyMapper.GetModelFromDTO(actualCompanyDTO);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(null)]
        public void GetModelFromDTO_WhenInvaildTestPassed_ShouldReturnArgumentNullException(CompanyDTO companyDTO)
        {
            Assert.Throws<ArgumentNullException>(() => _companyMapper.GetModelFromDTO(companyDTO));
        }
    }
}