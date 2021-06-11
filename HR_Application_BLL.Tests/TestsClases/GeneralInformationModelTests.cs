using HR_Application_BLL.Mappers.Base;
using HR_Application_BLL.Models.Base;
using HR_Application_BLL.Tests.Souces.GeneralInformationModel;
using HR_Application_DB_Logic.Models;
using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace HR_Application_BLL.Tests.TestsClases
{
    public class GeneralInformationModelTests
    {
        private GeneralInformationModelMapper _generalInformationModelMapper;

        [SetUp]
        public void Setup()
        {
            _generalInformationModelMapper = new GeneralInformationModelMapper();
        }


        [TestCaseSource(typeof(GetModelsFromDTOSource))]
        public void GetModelsFromDTO_WhenValidTestPassed_ShouldReturnListGeneralInformationModel(List<GeneralInformationDTO> generalInformationDTO, List<GeneralInformationModel> expected)
        {
            List<GeneralInformationModel> actual = _generalInformationModelMapper.GetModelsFromDTO(generalInformationDTO);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(null)]
        public void GetModelsFromDTO_WhenInvaildTestPassed_ShouldReturnArgumentNullException(List<GeneralInformationDTO> generalInformationDTO)
        {
            Assert.Throws<ArgumentNullException>(() => _generalInformationModelMapper.GetModelsFromDTO(generalInformationDTO));
        }

        [TestCaseSource(typeof(GetDTOFromModelSource))]
        public void GetDTOFromModel_WhenValidTestPassed_ShouldReturnGeneralInformationDTO(GeneralInformationModel generalInformationModel, GeneralInformationDTO expected)
        {
            GeneralInformationDTO actual = _generalInformationModelMapper.GetDTOFromModel(generalInformationModel);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(null)]
        public void GetDTOFromModel_WhenInvaildTestPassed_ShouldReturnArgumentNullException(GeneralInformationModel generalInformationModel)
        {
            Assert.Throws<ArgumentNullException>(() => _generalInformationModelMapper.GetDTOFromModel(generalInformationModel));
        }

        [TestCaseSource(typeof(GetModelFromDTOSource))]
        public void GetModelsFromDTO_WhenInvaildTestPassed_ShouldReturnGeneralInformationModelByID(GeneralInformationDTO generalInformationDTO, GeneralInformationModel expected)
        {
            GeneralInformationModel actual = _generalInformationModelMapper.GetModelFromDTO(generalInformationDTO);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(null)]
        public void GetModelFromDTO_WhenInvaildTestPassed_ShouldReturnArgumentNullException(GeneralInformationDTO generalInformationDTO)
        {
            Assert.Throws<ArgumentNullException>(() => _generalInformationModelMapper.GetModelFromDTO(generalInformationDTO));
        }
    }
}
