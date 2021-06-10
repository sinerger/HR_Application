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
    public class UserMapperGetUserFromModelSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[]
            {
                new UserDTO()
                {
                    ID =1,
                    FirstName = "Rostik",
                    LastName = "Potyrai",
                    CompanyID = 1,
                    Email = "1234567890@gmail.com",
                    Password = "1234567890"
                },
                new User()
                {
                    ID =1,
                    FirstName = "Rostik",
                    LastName = "Potyrai",
                    Email = "1234567890@gmail.com",
                    Password = "1234567890"
                }
            };
        }
    }
}
