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
    public class UserMapperGetModelFromUserSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[]
            {
                new User()
                {
                    ID =1,
                    FirstName = "Rostik",
                    LastName = "Potyrai",
                    Email = "1234567890@gmail.com",
                    Password = "1234567890",
                    Company = new Company()
                        {
                            ID = 1,
                            Title = "WizardsDev",
                            Description = "IT company",
                            Adress = new Adress()
                            {
                                ID = 1,
                                CityID=1,
                                ApartmentNumber = 1,
                                Street = "Lenina",
                                Block = "perviy",
                                HourseNumber = 1,
                                PostIndex = 49000,
                                City = new CityModel()
                                {
                                    ID = 1,
                                    Name = "Dnipro",
                                    CountryID = 1
                                },
                                Country = new CountryModel()
                                {
                                    ID = 1,
                                    Name = "Ukraine"
                                }
                            },
                            Departments = new List<Department>()
                            {
                                new Department()
                                {
                                    ID = 1,
                                    Title = "CRM",
                                    Description = "CRM doing work"
                                },
                                new Department()
                                {
                                    ID = 2,
                                    Title = "Mobile",
                                    Description = "Mobile doing work"
                                }
                            }
                        },
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
        }
    }
}
