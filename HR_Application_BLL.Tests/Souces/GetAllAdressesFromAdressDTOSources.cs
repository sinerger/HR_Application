using HR_Application_BLL.Models;
using HR_Application_DB_Logic.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace HR_Application_BLL.Tests.Souces
{
    public class GetAllAdressesFromAdressDTOSources : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[]
            {
                new List<AdressDTO>()
                {
                    new AdressDTO()
                    {
                        ID = 1,
                        Street = "Lenina",
                        HouseNumber = 1,
                        Block = "1",
                        ApartmentNumber = 123,
                        PostIndex = 10000,
                        City = new CityDTO()
                        {
                            ID = 1,
                            Name = "Dnipro",
                            CountryID = 1
                        },
                        Country = new CountryDTO()
                        {
                            ID = 1,
                            Name = "Ukraine"
                        }
                    },
                    new AdressDTO()
                    {
                        ID = 2,
                        Street = "Pushjina",
                        HouseNumber = 18,
                        Block = "35",
                        ApartmentNumber = 87,
                        PostIndex = 49157,
                        City = new CityDTO()
                        {
                            ID = 2,
                            Name = "Kiev",
                            CountryID = 1
                        },
                        Country = new CountryDTO()
                        {
                            ID = 1,
                            Name = "Ukraine"
                        }
                    }
                },
                new List<Adress>()
                {
                    new Adress()
                    {
                        ID = 1,
                        City = "Dnipro",
                        Country = "Ukraine"
                    },
                    new Adress()
                    {
                        ID = 2,
                        City = "Kiev",
                        Country = "Ukraine"
                    }
                }
            };
        }
    }
}
