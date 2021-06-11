using HR_Application_BLL.Mappers.Base;
using HR_Application_BLL.Models.Base;
using HR_Application_BLL.Tests.Souces.Comment;
using HR_Application_DB_Logic.Models;
using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace HR_Application_BLL.Tests.TestsClases
{
    public class CommentMapperTests
    {
        private CommentMapper _commentMapper;

        [SetUp]
        public void Setup()
        {
            _commentMapper = new CommentMapper();
        }

        [TestCaseSource(typeof(GetModelsFromDTOSource))]
        public void GetModelsFromDTO_WhenValidTestPassed_ShouldReturnListCommentModels(List<CommentDTO> actualCommentsDTO, List<CommentModel> expected)
        {
            List<CommentModel> actual = _commentMapper.GetModelsFromDTO(actualCommentsDTO);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(null)]
        public void GetModelsFromDTO_WhenInvaildTestPassed_ShouldReturnArgumentNullException(List<CommentDTO> commentsModel)
        {
            Assert.Throws<ArgumentNullException>(() => _commentMapper.GetModelsFromDTO(commentsModel));
        }

        [TestCaseSource(typeof(GetDTOFromModelSource))]
        public void GetDTOFromModel_WhenValidTestPassed_ShouldReturnCommentDTO(CommentModel commentModel, CommentDTO expected)
        {
            CommentDTO actual = _commentMapper.GetDTOFromModel(commentModel);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(null)]
        public void GetDTOFromModel_WhenInvaildTestPassed_ShouldReturnArgumentNullException(CommentModel commentModel)
        {
            Assert.Throws<ArgumentNullException>(() => _commentMapper.GetDTOFromModel(commentModel));
        }

        [TestCaseSource(typeof(GetModelFromDTOSource))]
        public void GetModelsFromDTO_WhenInvaildTestPassed_ShouldReturnCommentModelByID(CommentDTO actualCommentDTO, CommentModel expected)
        {
            CommentModel actual = _commentMapper.GetModelFromDTO(actualCommentDTO);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(null)]
        public void GetModelFromDTO_WhenInvaildTestPassed_ShouldReturnArgumentNullException(CommentDTO commentDTO)
        {
            Assert.Throws<ArgumentNullException>(() => _commentMapper.GetModelFromDTO(commentDTO));
        }
    }
}
