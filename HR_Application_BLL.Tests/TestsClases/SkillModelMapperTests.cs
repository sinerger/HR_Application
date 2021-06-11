using HR_Application_BLL.Mappers.Base;
using HR_Application_BLL.Models.Base;
using HR_Application_BLL.Tests.Souces.Skill;
using HR_Application_DB_Logic.Models;
using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace HR_Application_BLL.Tests.TestsClases
{
   public class SkillModelMapperTests
    {
        private SkillModelMapper _skillMapper;

        [SetUp]
        public void Setup()
        {
            _skillMapper = new SkillModelMapper();
        }

        [TestCaseSource(typeof(GetModelsFromDTOSource))]
        public void GetModelsFromDTO_WhenValidTestPassed_ShouldReturnListSkillModels(List<SkillDTO> actualSkillDTO, List<SkillModel> expected)
        {
            List<SkillModel> actual = _skillMapper.GetModelsFromDTO(actualSkillDTO);

            Assert.AreEqual(expected, actual);
        }

        [TestCaseSource(typeof(GetModelFromDTOSource))]
        public void GetModelFromDTO_WhenValidTestPassed_ShouldReturnSkillModelByID(SkillDTO actualSkillDTO, SkillModel expected)
        {
            SkillModel actual = _skillMapper.GetModelFromDTO(actualSkillDTO);

            Assert.AreEqual(expected, actual);
        }

        [TestCaseSource(typeof(GetDTOFromModelSource))]
        public void GetDTOFromModel_WhenValidTestPassed(SkillModel skillModel, SkillDTO expected)
        {
            SkillDTO actual = _skillMapper.GetDTOFromModel(skillModel);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(null)]
        public void GetDTOFromModel_WhenInvaildTestPassed_ShouldReturnArgumentNullException(SkillModel skillModel)
        {
            Assert.Throws<ArgumentNullException>(() => _skillMapper.GetDTOFromModel(skillModel));
        }
    }
}
