using HR_Application_BLL.Mappers.Base;
using HR_Application_BLL.Models.Base;
using HR_Application_BLL.Tests.Souces.LevelsPosition;
using HR_Application_DB_Logic.Interfaces;
using HR_Application_DB_Logic.Models;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using HR_Application_BLL.Base.Models;

namespace HR_Application_BLL.Tests.TestsClases
{
    public class LevelsPositionMapperTests
    {
        private LevelsPositionMapper _levelsPositionMapper;
        [SetUp]
        public void Setup()
        {
            _levelsPositionMapper = new LevelsPositionMapper();
        }

        [TestCaseSource(typeof(GetModelsFromDTOSource))]
        public void GetModelsFromDTO_WhenValidTestPassed_ShouldReturnListLevelsPositionModels(List<LevelsPositionDTO> actualListLevelsPositionDTO, List<LevelsPositionModel> expected)
        {
            List<LevelsPositionModel> actual = _levelsPositionMapper.GetModelsFromDTO(actualListLevelsPositionDTO);

            Assert.AreEqual(expected, actual);
        }

        [TestCaseSource(typeof(GetModelFromDTOSource))]
        public void GetModelFromDTO_WhenValidTestPassed_ShouldReturnLevelsPositionModelByID(LevelsPositionDTO actualLevelsPositionDTO, LevelsPositionModel expected)
        {
            LevelsPositionModel actual = _levelsPositionMapper.GetModelFromDTO(actualLevelsPositionDTO);

            Assert.AreEqual(expected, actual);
        }

        [TestCaseSource(typeof(GetDTOFromModelSource))]
        public void GetDTOFromModel_WhenValidTestPassed(LevelsPositionModel levelsPositionModel, LevelsPositionDTO expected)
        {
            LevelsPositionDTO actual = _levelsPositionMapper.GetDTOFromModel(levelsPositionModel);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(null)]
        public void GetDTOFromModel_WhenInvaildTestPassed_ShouldReturnArgumentNullException(LevelsPositionModel levelsPositionModel)
        {
            Assert.Throws<ArgumentNullException>(() => _levelsPositionMapper.GetDTOFromModel(levelsPositionModel));
        }
    }
}
