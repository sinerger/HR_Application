using HR_Application_BLL.Mappers.Base;
using HR_Application_BLL.Models.Base;
using HR_Application_BLL.Tests.Souces.LevelSkill;
using HR_Application_DB_Logic.Models;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace HR_Application_BLL.Tests.TestsClases
{
    public class LevelSkillMapperTests
    {
        private LevelSkillModelMapper _levelSkillMapper;

        [SetUp]
        public void Setup()
        {
            _levelSkillMapper = new LevelSkillModelMapper();
        }

        [TestCaseSource(typeof(GetModelsFromDTOSource))]
        public void GetModelsFromDTO_WhenValidTestPassed_ShouldReturnListLevelSkillModels(List<LevelSkillDTO> actualListLevelSkillDTO, List<LevelSkillModel> expected)
        {
            List<LevelSkillModel> actual = _levelSkillMapper.GetModelsFromDTO(actualListLevelSkillDTO);

            Assert.AreEqual(expected, actual);
        }

        [TestCaseSource(typeof(GetModelFromDTOSource))]
        public void GetModelFromDTO_WhenValidTestPassed_ShouldReturnLevelSkillModelByID(LevelSkillDTO actualLevelSkillDTO, LevelSkillModel expected)
        {
            LevelSkillModel actual = _levelSkillMapper.GetModelFromDTO(actualLevelSkillDTO);

            Assert.AreEqual(expected, actual);
        }

        [TestCaseSource(typeof(GetDTOFromModelSource))]
        public void GetDTOFromModel_WhenValidTestPassed(LevelSkillModel levelSkillModel, LevelSkillDTO expected)
        {
            LevelSkillDTO actual = _levelSkillMapper.GetDTOFromModel(levelSkillModel);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(null)]
        public void GetDTOFromModel_WhenInvaildTestPassed_ShouldReturnArgumentNullException(LevelSkillModel levelSkillModel)
        {
            Assert.Throws<ArgumentNullException>(() => _levelSkillMapper.GetDTOFromModel(levelSkillModel));
        }
    }
}
