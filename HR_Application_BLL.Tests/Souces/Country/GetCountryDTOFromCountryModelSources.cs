using HR_Application_BLL.Models.Base;
using HR_Application_DB_Logic.Models;
using System.Collections;
using System.Collections.Generic;

namespace HR_Application_BLL.Tests.Souces.Country
{
    public class GetCountryDTOFromCountryModelSources : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[]
            {
                new CountryModel()
                {
                    ID = 1,
                    Name = "Ukraine"
                },
                new CountryDTO()
                {
                    ID = 1,
                    Name = "Ukraine"
                }
            };
            yield return new object[]
            {
                new CountryModel()
                {
                    ID = 2,
                    Name = "Russia"
                },
                new CountryDTO()
                {
                    ID = 2,
                    Name = "Russia"
                }
            };
            yield return new object[]
            {
                new CountryModel()
                {
                    ID = 3,
                    Name = "Turkey"
                },
                new CountryDTO()
                {
                    ID = 3,
                    Name = "Turkey"
                }
            };
        }
    }
}
