using HR_Application_BLL.Base.Models;
using HR_Application_DB_Logic.Models;
using System.Collections;

namespace HR_Application_BLL.Tests.Souces.UserModelSource
{
    class GetModelFromDTOSource : IEnumerable
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
                    Password = "1234567890",
                },
                new UserModel()
                {
                    ID =1,
                    FirstName = "Rostik",
                    LastName = "Potyrai",
                    CompanyID = 1,
                    Email = "1234567890@gmail.com",
                    Password = "1234567890",
                }
            };
            yield return new object[]
            {
                new UserDTO()
                {
                    ID =1,
                    FirstName = "Alex",
                    LastName = "Sasha",
                    CompanyID = 2,
                    Email = "0987654321@gmail.com",
                    Password = "0987654321",
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
            };
        }
    }
}
