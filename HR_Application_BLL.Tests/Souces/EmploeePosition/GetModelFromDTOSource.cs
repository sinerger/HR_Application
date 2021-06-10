using HR_Application_BLL.Base.Models;
using HR_Application_DB_Logic.Models;
using System.Collections;

namespace HR_Application_BLL.Tests.Souces.EmploeePosition
{
    class GetModelFromDTOSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[]
           {
                new EmployeePositionDTO()
                {
                    ID = 1,
                    EmployeeID = 12,
                    HiderDate = "1",
                    FiredDate = "25",
                    IsActual = true,
                    LevelPositionID = 1,
                    PositionID = 1
                },
                new EmployeePositionModel()
                {
                   ID = 1,
                    EmployeeID = 12,
                    HiderDate = "1",
                    FiredDate = "25",
                    IsActual = true,
                    LevelPositionID = 1,
                    PositionID = 1
                }
           };
            yield return new object[]
            {
                new EmployeePositionDTO()
                {
                    ID = 2,
                    EmployeeID = 2,
                    HiderDate = "1",
                    FiredDate = "2",
                    IsActual = true,
                    LevelPositionID = 1,
                    PositionID = 1
                },
                new EmployeePositionModel()
                {
                    ID = 2,
                    EmployeeID = 2,
                    HiderDate = "1",
                    FiredDate = "2",
                    IsActual = true,
                    LevelPositionID = 1,
                    PositionID = 1
                }
            };            
        }
    }
}
