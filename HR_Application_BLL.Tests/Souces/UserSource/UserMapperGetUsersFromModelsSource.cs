using HR_Application_BLL.Base.Models;
using HR_Application_BLL.Models;
using HR_Application_BLL.Models.Base;
using HR_Application_DB_Logic.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace HR_Application_BLL.Tests.Souces.UserSource
{
    public class UserMapperGetUsersFromModelsSource : IEnumerable
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
                        ID =2,
                        FirstName = "Alex",
                        LastName = "Sasha",
                        CompanyID = 2,
                        Email = "0987654321@gmail.com",
                        Password = "0987654321",
                    }
                },
                new List<User>()
                {
                    new User()
                    {
                        ID =1,
                        FirstName = "Rostik",
                        LastName = "Potyrai",
                        Email = "1234567890@gmail.com",
                        Password = "1234567890"
                    },
                    new User()
                    {
                        ID =2,
                        FirstName = "Alex",
                        LastName = "Sasha",
                        Email = "0987654321@gmail.com",
                        Password = "0987654321"
                    }
                }
            };
        }
    }
}
