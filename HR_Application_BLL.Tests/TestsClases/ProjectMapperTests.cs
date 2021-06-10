using HR_Application_BLL.Mappers.Base;
using HR_Application_BLL.Models.Base;
using HR_Application_BLL.Tests.Souces.Project;
using HR_Application_DB_Logic.Models;
using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace HR_Application_BLL.Tests.TestsClases
{
    public class ProjectMapperTests
    {
        private ProjectMapper _projectMapper;

        [SetUp]
        public void Setup()
        {
            _projectMapper = new ProjectMapper();
        }

        [TestCaseSource(typeof(GetModelsFromDTOSource))]
        public void GetModelsFromDTO_WhenValidTestPassed_ShouldReturnListProjectModels(List<ProjectDTO> actualProjectsDTO, List<ProjectModel> expected)
        {
            List<ProjectModel> actual = _projectMapper.GetModelsFromDTO(actualProjectsDTO);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(null)]
        public void GetModelsFromDTO_WhenInvaildTestPassed_ShouldReturnArgumentNullException(List<ProjectDTO> projectsModel)
        {
            Assert.Throws<ArgumentNullException>(() => _projectMapper.GetModelsFromDTO(projectsModel));
        }

        [TestCaseSource(typeof(GetDTOFromModelSource))]
        public void GetDTOFromModel_WhenValidTestPassed_ShouldReturnProjectDTO(ProjectModel projectModel, ProjectDTO expected)
        {
            ProjectDTO actual = _projectMapper.GetDTOFromModel(projectModel);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(null)]
        public void GetDTOFromModel_WhenInvaildTestPassed_ShouldReturnArgumentNullException(ProjectModel projectModel)
        {
            Assert.Throws<ArgumentNullException>(() => _projectMapper.GetDTOFromModel(projectModel));
        }

        [TestCaseSource(typeof(GetModelFromDTOSource))]
        public void GetModelsFromDTO_WhenInvaildTestPassed_ShouldReturnProjectModelByID(ProjectDTO actualProjectDTO, ProjectModel expected)
        {
            ProjectModel actual = _projectMapper.GetModelFromDTO(actualProjectDTO);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(null)]
        public void GetModelFromDTO_WhenInvaildTestPassed_ShouldReturnArgumentNullException(ProjectDTO projectDTO)
        {
            Assert.Throws<ArgumentNullException>(() => _projectMapper.GetModelFromDTO(projectDTO));
        }
    }
}