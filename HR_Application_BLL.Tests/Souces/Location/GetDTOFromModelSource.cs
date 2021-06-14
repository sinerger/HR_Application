using HR_Application_BLL.Models.Base;
using HR_Application_DB_Logic.Models;
using System.Collections;

namespace HR_Application_BLL.Tests.Souces.Location
{
    public class GetDTOFromModelSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[]
            {
                new LocationModel()
                {
                    ID = 1,
                    CityID=1
                },
                new LocationDTO()
                {
                    ID = 1,
                    CityID=1
                }
            };
            yield return new object[]
            {
                new LocationModel()
                {
                    ID = 2,
                    CityID=2
                },
                new LocationDTO()
                {
                    ID = 2,
                    CityID=2
                }
            };
        }
    }
}
