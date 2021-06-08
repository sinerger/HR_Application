using HR_Application_BLL.Models.Base;
using HR_Application_DB_Logic.Models;
using System.Collections;

namespace HR_Application_BLL.Tests.Souces.Location
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
                    HourseNumber = 1,
                    PostIndex = 49000
                },
                new LocationModel()
                {
                    ID = 1,
                    CityID=1,
                    ApartmentNumber = 1,
                    Street = "Lenina",
                    Block = "perviy",
                    HourseNumber = 1,
                    PostIndex = 49000
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
                    HourseNumber = 15,
                    PostIndex = 25000
                },
                new LocationModel()
                {
                    ID = 2,
                    CityID=2,
                    ApartmentNumber = 13,
                    Street = "Pushkina",
                    Block = "vtoroy",
                    HourseNumber = 15,
                    PostIndex = 25000
                }
            };
        }
    }
}
