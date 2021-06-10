﻿using HR_Application_BLL.Base.Models;
using HR_Application_BLL.Models;
using HR_Application_BLL.Models.Base;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace HR_Application_BLL.Tests.Souces.UserSource
{
    public class InvalidGetUserFromModelsSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[]
            {
                null,
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
                }
            };
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
                },
                null
            };
        }
    }
}
