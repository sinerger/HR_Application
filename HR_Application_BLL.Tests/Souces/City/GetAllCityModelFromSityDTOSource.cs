using HR_Application_BLL.Models.Base;
using HR_Application_DB_Logic.Models;
using System.Collections;
using System.Collections.Generic;

namespace HR_Application_BLL.Tests.Souces.City
{
    class GetAllCityModelFromSityDTOSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[]
            {
                new List<CityDTO>()
                {
                    new CityDTO()
                    {
                        ID = 1,
                        Name = "Dnipro",
                        CountryID = 1
                    },
                    new CityDTO()
                    {
                        ID = 2,
                        Name = "Kiev",
                        CountryID = 1
                    },
                    new CityDTO()
                    {
                        ID = 3,
                        Name = "Moscow",
                        CountryID = 2
                    }
                },
                new List<CityModel>()
                {
                    new CityModel()
                    {
                        ID = 1,
                        Name = "Dnipro",
                        CountryID = 1
                    },
                    new CityModel()
                    {
                        ID = 2,
                        Name = "Kiev",
                        CountryID = 1
                    },
                    new CityModel()
                    {
                        ID = 3,
                        Name = "Moscow",
                        CountryID = 2
                    }
                }
            };
        }
    }
}
