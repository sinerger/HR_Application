using HR_Application_BLL.Models.Base;
using HR_Application_DB_Logic.Models;
using System.Collections;
using System.Collections.Generic;

namespace HR_Application_BLL.Tests.Souces.Position
{
    public class GetModelFromDTOSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[]
           {
                new PositionDTO()
                {
                    ID = 1,
                    Title = "Middle",
                    Description = "lite"
                },
                new Models.Base.PositionModel()
                {
                    ID = 1,
                    Title = "Middle",
                    Description = "lite"
                }
           };
            yield return new object[]
            {
                 new PositionDTO()
                 {
                     ID = 2,
                     Title = "junior",
                     Description = "lite"
                 },
                 new Models.Base.PositionModel()
                 {
                     ID = 2,
                     Title = "junior",
                     Description = "lite"
                 }
            };
            yield return new object[]
            {
               new PositionDTO()
               {
                   ID = 3,
                   Title = "Senior",
                   Description = "strong"
               },
               new Models.Base.PositionModel()
               {
                   ID = 3,
                   Title = "Senior",
                   Description = "strong"
               }
            };
        }
    }
}
