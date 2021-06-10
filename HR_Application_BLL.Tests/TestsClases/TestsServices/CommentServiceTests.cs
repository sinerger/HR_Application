using System.Collections.Generic;
using System.Text;
using HR_Application_BLL.Models;
using HR_Application_BLL.Models.Base;
using HR_Application_BLL.Services;
using HR_Application_BLL.Tests.Souces.AdressServiceSources;
using HR_Application_DB_Logic.Interfaces;
using HR_Application_DB_Logic.Models;
using Moq;
using NUnit.Framework;

namespace HR_Application_BLL.Tests.TestsClases.TestsServices
{
    public class CommentServiceTests
    {
        private Mock<IDBController> _mock;
        private CommentService _commentService;

        [SetUp]
        public void Setup()
        {
            _mock = new Mock<IDBController>();
            _commentService = new CommentService(_mock.Object);
        }

        [TestCaseSource(typeof(AdressServicesGetAllSoruce))]
        public void GetAll_WhenValidTestPassed_ShouldReturnListCOfComments(List<CommentDTO> returnedCommentsDTO, List<CommentModel> expected)
        {
            _mock.Setup(dbController => dbController.CommentRepository.GetAll()).Returns(returnedCommentsDTO);

            var actual = _commentService.GetAll();

            Assert.AreEqual(expected, actual);
        }

        [TestCaseSource(typeof(AdressServiceGetByIDCource))]
        public void GetByID_WhenValidTestPassed_ShouldReturnCommentObject(int id, CommentDTO returnedCommentsDTO, CommentModel expected)
        {
            _mock.Setup(dbController => dbController.CommentRepository.GetByID(id)).Returns(returnedCommentsDTO);
            
            var actual = _commentService.GetByID(id);

            Assert.AreEqual(expected, actual);
        }

    }
}
