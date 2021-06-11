using HR_Application_BLL.Mappers.Base;
using HR_Application_BLL.Models.Base;
using HR_Application_BLL.Tests.Souces.Position;
using HR_Application_DB_Logic.Interfaces;
using HR_Application_DB_Logic.Models;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace HR_Application_BLL.Tests.TestsClases
{
    public class PositionMapperTests
    {
        private PositionMapper _positionMapper;

        [SetUp]
        public void Setup()
        {
            _positionMapper = new PositionMapper();
        }

        [TestCaseSource(typeof(GetModelsFromDTOSource))]
        public void GetModelsFromDTO_WhenValidTestPassed_ShouldReturnListPositionModels(List<PositionDTO> actualListPositionDTO, List<PositionModel> expected)
        {
            List<PositionModel> actual = _positionMapper.GetModelsFromDTO(actualListPositionDTO);

            Assert.AreEqual(expected, actual);
        }

        [TestCaseSource(typeof(GetModelFromDTOSource))]
        public void GetModelFromDTO_WhenValidTestPassed_ShouldReturnPositionModelByID(PositionDTO actualPositionDTO, PositionModel expected)
        {
            PositionModel actual = _positionMapper.GetModelFromDTO(actualPositionDTO);

            Assert.AreEqual(expected, actual);
        }

        [TestCaseSource(typeof(GetDTOFromModelSource))]
        public void GetDTOFromModel_WhenValidTestPassed(PositionModel positionModel, PositionDTO expected)
        {
            PositionDTO actual = _positionMapper.GetDTOFromModel(positionModel);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(null)]
        public void GetDTOFromModel_WhenInvaildTestPassed_ShouldReturnArgumentNullException(PositionModel positionModel)
        {
            Assert.Throws<ArgumentNullException>(() => _positionMapper.GetDTOFromModel(positionModel));
        }

    }
}
