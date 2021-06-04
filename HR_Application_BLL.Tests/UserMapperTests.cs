using System;
using System.Collections.Generic;
using System.Text;
using HR_Application_BLL.Controllers;
using HR_Application_BLL.Models;
using HR_Application_BLL.Tests.Souces;
using HR_Application_DB_Logic;
using HR_Application_DB_Logic.Interfaces;
using HR_Application_DB_Logic.Models;
using Moq;
using NUnit.Framework;

namespace HR_Application_BLL.Tests
{
    public class UserMapperTests
    {
        private Mock<IDBController> _mock;
        UserMapper _userMapper;

        [SetUp]
        public void Setup()
        {
            _mock = new Mock<IDBController>();
            _userMapper = new UserMapper(_mock.Object); 

        }
        [TestCaseSource(typeof(GetAllFromUserDTOToUserModelSource))]
        public void GetAllFromUserDTOToUserModel_WhenValidTestPassed_ShouldReturnListUserModel(List<UserDTO> returnedUsersDTO,List<UserModel> expected)
        {
            _mock.Setup(getAll => (getAll.UserRepository.GetAll())).Returns(returnedUsersDTO);
            List<UserModel> actual = _userMapper.GetAllFromUserDTOToUserModel();

            Assert.AreEqual(expected, actual);
        }

        private object GetAllFromUserDTOToUserModelSouce()
        {
            throw new NotImplementedException();
        }

        //public void SqrSumm(int a, int b, int adderReturns, int expexted)
        //{
        //    mock.Setup(adder => (adder.Add(a, b))).Returns(adderReturns);

        //    int actual = calc.SqrSumm(a, b);

        //    Assert.AreEqual(expexted, actual);
        //}
        //public void SummSqr(int a, int b, int expextedA, int expextedB)
        //{
        //    mock.Setup(adder => (adder.Add(expextedA, expextedB))).Verifiable();

        //    calc.SummSqr(a, b);

        //    mock.Verify();
        //}
        //public void SqrSummSqr(int a, int b, int expextedA, int expextedB, int adderReturns, int expexted)
        //{
        //    mock.Setup(adder => (adder.Add(expextedA, expextedB))).Returns(adderReturns).Verifiable();

        //    int actual = calc.SqrSummSqr(a, b);

        //    Assert.AreEqual(expexted, actual);
        //    mock.Verify();

        //}
    }
}
