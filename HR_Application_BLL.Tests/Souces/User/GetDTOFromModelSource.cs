using HR_Application_BLL.Base.Models;
using HR_Application_DB_Logic.Models;
using System.Collections;

namespace HR_Application_BLL.Tests.Souces.User
{
    class GetDTOFromModelSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[]
            {
                new UserModel()
                {
                    ID =1,
                    FirstName = "Rostik",
                    LastName = "Potyrai",
                    CompanyID = 1,
                    Email = "1234567890@gmail.com",
                    Password = "1234567890",
                    IsActual = true
                },
                new UserDTO()
                {
                    ID =1,
                    FirstName = "Rostik",
                    LastName = "Potyrai",
                    CompanyID = 1,
                    Email = "1234567890@gmail.com",
                    Password = "1234567890",
                    IsActual = true
                }
            };
            yield return new object[]
            {
                new UserModel()
                {
                    ID =2,
                    FirstName = "Alex",
                    LastName = "Sasha",
                    CompanyID = 2,
                    Email = "0987654321@gmail.com",
                    Password = "0987654321",
                    IsActual = true
                },
                new UserDTO()
                {
                    ID =2,
                    FirstName = "Alex",
                    LastName = "Sasha",
                    CompanyID = 2,
                    Email = "0987654321@gmail.com",
                    Password = "0987654321",
                    IsActual = true
                }
            };
        }
    }
}
