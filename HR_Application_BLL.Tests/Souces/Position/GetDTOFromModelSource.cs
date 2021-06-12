using HR_Application_BLL.Models.Base;
using HR_Application_DB_Logic.Models;
using System.Collections;

namespace HR_Application_BLL.Tests.Souces.Position
{
    public class GetDTOFromModelSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[]
          {
                new Models.Base.PositionModel()
                {
                    ID = 1,
                    Title = "Middle",
                    Description = "strong"
                },
                new PositionDTO()
                {
                    ID = 1,
                    Title = "Middle",
                    Description = "strong"
                }
          };
            yield return new object[]
            {
                new Models.Base.PositionModel()
                {
                    ID = 2,
                    Title = "junior",
                    Description = "strong"
                },
                new PositionDTO()
                {
                    ID = 2,
                    Title = "junior",
                    Description = "strong"
                }
            };
        }
    }
}
