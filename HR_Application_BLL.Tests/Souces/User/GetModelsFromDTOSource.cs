using HR_Application_BLL.Models;
using HR_Application_DB_Logic.Models;
using System;
using System.Collections;
using System.Collections.Generic;

namespace HR_Application_BLL.Tests.Souces.User
{
    class GetModelsFromDTOSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[]
            {
                new List<UserDTO>()
                {
                    new UserDTO()
                    {
                        ID =1,
                        FirstName = "Rostik",
                        LastName = "Potyrai",
                        CompanyID = 1,
                        Email = "1234567890@gmail.com",
                        Password = "1234567890",
                    },
                    new UserDTO()
                    {
                        ID =1,
                        FirstName = "Alex",
                        LastName = "Sasha",
                        CompanyID = 2,
                        Email = "0987654321@gmail.com",
                        Password = "0987654321",
                    }
                },
                new List<UserModel>()
                {
                    new UserModel()
                    {
                        ID =1,
                        FirstName = "Rostik",
                        LastName = "Potyrai",
                        CompanyID = 1,
                        Email = "1234567890@gmail.com",
                        Password = "1234567890",
                    },
                    new UserModel()
                    {
                        ID =1,
                        FirstName = "Alex",
                        LastName = "Sasha",
                        CompanyID = 2,
                        Email = "0987654321@gmail.com",
                        Password = "0987654321",
                    }
                }
            };
        }
    }
}
