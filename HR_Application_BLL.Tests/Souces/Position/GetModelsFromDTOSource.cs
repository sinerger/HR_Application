using HR_Application_BLL.Models.Base;
using HR_Application_DB_Logic.Models;
using System.Collections;
using System.Collections.Generic;

namespace HR_Application_BLL.Tests.Souces.Position
{
    class GetModelsFromDTOSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[]
           {
                new List<PositionDTO>()
                {
                    new PositionDTO()
                    {
                        ID = 1,
                        Title = "Middle",
                        Description = "Strong"
                    },
                    new PositionDTO()
                    {
                        ID = 2,
                        Title = "junior",
                        Description = "lite"
                    },
                    new PositionDTO()
                    {
                        ID = 3,
                        Title = "junior",
                        Description = "strong"
                    }
                },
                new List<PositionModel>()
                {
                    new PositionModel()
                    {
                        ID = 1,
                        Title = "Middle",
                        Description = "Strong"
                    },
                    new PositionModel()
                    {
                        ID = 2,
                        Title = "junior",
                        Description = "lite"
                    },
                    new PositionModel()
                    {
                        ID = 3,
                        Title = "junior",
                        Description = "strong"
                    }
                }
            };
        }
    }
}
