using HR_Application_DB_Logic.Models;
using HR_Application_BLL.Models;
using System.Collections;
using System.Collections.Generic;
using HR_Application_BLL.Models.Base;


namespace HR_Application_BLL.Tests.Souces.AdressSources
{
    public class GetModelFromDTOSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[]
            {
                new LocationDTO()
                {
                    ID = 1,
                    CityID=1,
                    ApartmentNumber = 1,
                    Street = "Lenina",
                    Block = "perviy",
                    HouseNumber = 1,
                    PostIndex = 49000
                },
                new CityDTO()
                {
                    ID = 1,
                    Name = "Dnipro",
                    CountryID = 1
                },
                new CountryDTO()
                {
                    ID = 1,
                    Name = "Ukraine"
                },
                new Models.Adress()
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
                }
            };
            yield return new object[]
            {
                new LocationDTO()
                {
                    ID = 2,
                    CityID=2,
                    ApartmentNumber = 13,
                    Street = "Pushkina",
                    Block = "vtoroy",
                    HouseNumber = 15,
                    PostIndex = 25000
                },
                new CityDTO()
                {
                    ID = 2,
                    Name = "Moscow",
                    CountryID = 2
                },
                new CountryDTO()
                {
                    ID = 2,
                    Name = "Russia"
                },
                new Models.Adress()
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
                }
            };
        }
    }
}
