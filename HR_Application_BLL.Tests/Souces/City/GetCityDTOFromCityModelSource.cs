using HR_Application_BLL.Models.Base;
using HR_Application_DB_Logic.Models;
using System.Collections;

namespace HR_Application_BLL.Tests.Souces.City
{
    public class GetCityDTOFromCityModelSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[]
            {
                new CityModel()
                {
                    ID = 1,
                    Name = "Dnipro",
                    CountryID = 1
                },
                new CityDTO()
                {
                    ID = 1,
                    Name = "Dnipro",
                    CountryID = 1
                }
            };
            yield return new object[]
            {
                new CityModel()
                {
                    ID = 2,
                    Name = "Kiev",
                    CountryID = 1
                },
                new CityDTO()
                {
                    ID = 2,
                    Name = "Kiev",
                    CountryID = 1
                }
            };
            yield return new object[]
            {
                new CityModel()
                {
                    ID = 3,
                    Name = "Moscow",
                    CountryID = 2
                },
                new CityDTO()
                {
                    ID = 3,
                    Name = "Moscow",
                    CountryID = 2
                }
            };
        }
    }
}
