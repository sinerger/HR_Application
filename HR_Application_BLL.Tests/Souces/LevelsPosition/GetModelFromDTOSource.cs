using HR_Application_BLL.Models.Base;
using HR_Application_DB_Logic.Models;
using System.Collections;
using System.Collections.Generic;

namespace HR_Application_BLL.Tests.Souces.LevelsPosition
{
    class GetModelFromDTOSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[]
          {
                new LevelsPositionDTO()
                {
                    ID = 1,
                    Title = "Dnipro",
                    Description = "Dnipro"
                },
                new LevelsPositionModel()
                {
                    ID = 1,
                    Title = "Dnipro",
                    Description = "Dnipro"
                }
          };
            yield return new object[]
            {
                 new LevelsPositionDTO()
                 {
                     ID = 2,
                     Title = "Kiev",
                     Description = "Kiev"
                 },
                 new LevelsPositionModel()
                 {
                     ID = 2,
                     Title = "Kiev",
                     Description = "Kiev"
                 }
            };
            yield return new object[]
            {
               new LevelsPositionDTO()
               {
                   ID = 3,
                   Title = "Moscow",
                   Description = "Moscow"
               },
               new LevelsPositionModel()
               {
                   ID = 3,
                   Title = "Moscow",
                   Description = "Moscow"
               }
            };
        }
    }
}