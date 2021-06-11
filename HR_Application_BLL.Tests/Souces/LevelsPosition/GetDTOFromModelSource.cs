using HR_Application_BLL.Models.Base;
using HR_Application_DB_Logic.Models;
using System.Collections;

namespace HR_Application_BLL.Tests.Souces.LevelsPosition
{
    public class GetDTOFromModelSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[]
            {
                new LevelsPositionModel()
                {
                    ID = 1,
                    Title = "CRM",
                    Description = "CRM doing work"
                },
                new LevelsPositionDTO()
                {
                    ID = 1,
                    Title = "CRM",
                    Description = "CRM doing work"
                }
            };
            yield return new object[]
            {
                new LevelsPositionModel()
                {
                    ID = 2,
                    Title = "Mobile",
                    Description = "Mobile doing work"
                },
                new LevelsPositionDTO()
                {
                    ID = 2,
                    Title = "Mobile",
                    Description = "Mobile doing work"
                }
            };
        }
    }
}