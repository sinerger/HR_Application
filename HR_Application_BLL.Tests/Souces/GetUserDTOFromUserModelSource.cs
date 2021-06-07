using HR_Application_BLL.Models;
using HR_Application_DB_Logic.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace HR_Application_BLL.Tests.Souces
{
    public class GetUserDTOFromUserModelSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[]
            {
                new User()
                {
                    ID = 1,
                    FirstName = "FirstName",
                    LastName = "LastName",
                    Email = "1234567890@mail.com",
                    Password = "1234",
                    Company = "Wd",
                    City = "Dnipro"
                },
                new UserDTO()
                {
                    ID = 1,
                    FirstName = "FirstName",
                    LastName = "LastName",
                    Email = "1234567890@mail.com",
                    Password = "1234",
                    IsActual = true,
                    Company = new CompanyDTO()
                    {
                        Title = "Wd",
                    },
                    Adress = new AdressDTO()
                    {
                        City = new CityDTO()
                        {
                            Name= "Dnipro"
                        }
                    }
                }
            };
        }
    }
}
