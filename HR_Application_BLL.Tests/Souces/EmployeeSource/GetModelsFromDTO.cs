using HR_Application_BLL.Models.Base;
using HR_Application_DB_Logic.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace HR_Application_BLL.Tests.Souces.EmployeeSource
{
    public class GetModelsFromDTO : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[]
            {
                new List<EmployeeDTO>()
                {
                    new EmployeeDTO()
                    {
                        ID = 1,
                        Photo = "fadghrtwhtasojpj-j-9j-9u29yh8gya8y",
                        FirstName = "Petro",
                        LastName = "Zagorodniy",
                        LocationID = 1,
                        RegistrationDate = "26.08.1990",
                        IsActual = true,
                        StatusID = 1
                    },
                    new EmployeeDTO()
                    {
                        ID = 2,
                        Photo = "ger235fas-jv0zjhbpdf0[rw]eh-g0[ah",
                        FirstName = "Serhiy",
                        LastName = "Parasov",
                        LocationID = 2,
                        RegistrationDate = "02.11.1987",
                        IsActual = true,
                        StatusID = 2
                    }
                },
            new List<EmployeeModel>()
                {
                     new EmployeeModel()
                    {
                        ID = 1,
                        Photo = "fadghrtwhtasojpj-j-9j-9u29yh8gya8y",
                        FirstName = "Petro",
                        LastName = "Zagorodniy",
                        LocationID = 1,
                        RegistrationDate = "26.08.1990",
                        IsActual = true,
                        StatusID = 1
                    },
                    new EmployeeModel()
                    {
                        ID = 2,
                        Photo = "ger235fas-jv0zjhbpdf0[rw]eh-g0[ah",
                        FirstName = "Serhiy",
                        LastName = "Parasov",
                        LocationID = 2,
                        RegistrationDate = "02.11.1987",
                        IsActual = true,
                        StatusID = 2
                    }
                }
            };
        }
    }
}
