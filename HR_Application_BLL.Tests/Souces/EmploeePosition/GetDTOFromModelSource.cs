using HR_Application_BLL.Base.Models;
using HR_Application_DB_Logic.Models;
using System.Collections;

namespace HR_Application_BLL.Tests.Souces.EmploeePosition
{
    class GetDTOFromModelSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[]
             {
                new EmployeePositionModel()
                {
                    ID =1,
                    EmployeeID = 12,
                    HiredDate = "1",
                    FiredDate = "25",
                    IsActual = true,
                    LevelsPosition = 1,
                    PositionID = 1
                },
                new EmployeePositionDTO()
                {
                  ID =1,
                    EmployeeID = 12,
                    HiredDate = "1",
                    FiredDate = "25",
                    IsActual = true,
                    LevelsPosition = 1,
                    PositionID = 1
                }
             };
            yield return new object[]
            {
                new EmployeePositionModel()
                {
                    ID =2,
                    EmployeeID = 2,
                    HiredDate = "1",
                    FiredDate = "2",
                    IsActual = true,
                    LevelsPosition = 1,
                    PositionID = 1
                },
                new EmployeePositionDTO()
                {
                     ID =2,
                    EmployeeID = 2,
                    HiredDate = "1",
                    FiredDate = "2",
                    IsActual = true,
                    LevelsPosition = 1,
                    PositionID = 1
                }
            };
        }
    }
}
