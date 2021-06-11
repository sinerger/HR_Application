using HR_Application_BLL.Mappers;
using HR_Application_BLL.Models;
using HR_Application_BLL.Tests.Souces.CompetenceSources;
using HR_Application_DB_Logic.Models.Custom;
using NUnit.Framework;
using System.Collections.Generic;

namespace HR_Application_BLL.Tests.TestsClases
{
    public class CompetenceMapperTests
    {
        private CompetenceMapper _competenceMapper;

        [SetUp]
        public void Setup()
        {
            _competenceMapper = new CompetenceMapper();
        }

        [TestCaseSource(typeof(CompetenceGetCompetencesFromDTOSource))]
        public void GetCompetencesFromDTO_WhenValidTestPassed_ShouldReturnListCompetenceModel(
             List<EmployeeSkillDTO> employeeSkillsDTO, List<Competence> expected)
        {
            List<Competence> actual = _competenceMapper.GetCompetencesFromDTO(employeeSkillsDTO);

            Assert.AreEqual(expected, actual);
        }

        [TestCaseSource(typeof(CompetenceGetCompetenceFromDTOSource))]
        public void GetCompetenceFromDTO_WhenValidTestPassed_ShouldReturnCompetenceModelObj(
            EmployeeSkillDTO employeeSkillDTO, Competence expected)
        {
            Competence actual = _competenceMapper.GetCompetenceFromDTO(employeeSkillDTO);

            Assert.AreEqual(expected, actual);
        }

        [TestCaseSource(typeof(CompetenceGetDTOFromCompetenceSource))]
        public void GetDTOFromCompetence_WhenValidTestPassed_ShouldReturnCompetenceModelObj(
            Competence competence, EmployeeSkillDTO expected)
        {
            EmployeeSkillDTO actual = _competenceMapper.GetDTOFromCompetence(competence);

            Assert.AreEqual(expected, actual);
        }
    }
}
