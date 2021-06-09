using HR_Application_BLL.Base.Models;
using HR_Application_BLL.Models;
using HR_Application_BLL.Models.Base;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace HR_Application_BLL.Tests.Souces.UserSource
{
    class InvalidGetUsersFromModelsSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[]
            {
                null,
                new List<Company>()
                {
                    new Company()
                    {
                        ID = 1,
                        Title = "WizardsDev",
                        Desctiption = "IT company",
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
                        Departments = new List<DepartmentModel>()
                        {
                            new DepartmentModel()
                            {
                                ID = 1,
                                Title = "CRM",
                                Description = "CRM doing work"
                            },
                            new DepartmentModel()
                            {
                                ID = 2,
                                Title = "Mobile",
                                Description = "Mobile doing work"
                            }
                        }
                    },
                    new Company()
                    {
                        ID = 2,
                        Title = "SoftServ",
                        Desctiption = "Outsource company",
                        Adress = new Adress()
                        {
                            ID = 2,
                            CityID=2,
                            ApartmentNumber = 13,
                            Street = "Pushkina",
                            Block = "vtoroy",
                            HourseNumber = 15,
                            PostIndex = 25000,
                            City = new CityModel()
                            {
                                ID = 2,
                                Name = "Moscow",
                                CountryID = 2
                            },
                            Country = new CountryModel()
                            {
                                ID = 2,
                                Name = "Russia"
                            }
                        },
                        Departments = new List<DepartmentModel>()
                        {
                            new DepartmentModel()
                            {
                                ID = 1,
                                Title = "CRM",
                                Description = "CRM doing work"
                            },
                            new DepartmentModel()
                            {
                                ID = 2,
                                Title = "Mobile",
                                Description = "Mobile doing work"
                            }
                        }
                    }
                }
            };
            yield return new object[]
           {
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
                        ID =2,
                        FirstName = "Alex",
                        LastName = "Sasha",
                        CompanyID = 2,
                        Email = "0987654321@gmail.com",
                        Password = "0987654321",
                    }
                },
                null
           };
        }
    }
}
