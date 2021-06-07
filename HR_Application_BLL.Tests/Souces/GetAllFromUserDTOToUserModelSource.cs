using HR_Application_BLL.Models;
using HR_Application_DB_Logic.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace HR_Application_BLL.Tests.Souces
{
    public class GetAllFromUserDTOToUserModelSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            var usersDTO = new List<UserDTO>()
            {
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
                        ID = 1,
                        Title = "Wd",
                        LocationID = 1,
                        Description = "wd is cool",
                        IsActual = true
                    },
                    Adress = new AdressDTO()
                    {
                        ID = 1,
                        City = new CityDTO()
                        {
                            ID = 1,
                            Name= "Dnipro"
                        }
                    }
                },
                new UserDTO()
                {
                    ID = 2,
                    FirstName = "1FirstName1",
                    LastName = "1LastName1",
                    Email = "00000000@mail.com",
                    Password = "4141",
                    IsActual = true,
                    Company = new CompanyDTO()
                    {
                        ID = 2,
                        Title = "DVGA",
                        LocationID = 2,
                        Description = "DVGA is not cool",
                        IsActual = true
                    },
                    Adress = new AdressDTO()
                    {
                        ID = 2,
                        City = new CityDTO()
                        {
                            ID = 2,
                            Name= "KIEV"
                        }
                    }
                }
            };
            var userModels = new List<User>()
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
                new User()
                {
                    ID = 2,
                    FirstName = "1FirstName1",
                    LastName = "1LastName1",
                    Email = "00000000@mail.com",
                    Password = "4141",
                    Company = "DVGA",
                    City = "KIEV"
                }
            };

            yield return new object[]
            {
                usersDTO,
                userModels
            };
        }
    }
}

