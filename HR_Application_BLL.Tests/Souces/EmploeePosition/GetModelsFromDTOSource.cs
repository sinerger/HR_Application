using HR_Application_BLL.Base.Models;
using HR_Application_DB_Logic.Models;
using System.Collections;
using System.Collections.Generic;

namespace HR_Application_BLL.Tests.Souces.EmploeePosition
{
    class GetModelsFromDTOSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[]
            {
                new List<EmployeePositionDTO>()
                {
                    new EmployeePositionDTO()
                    {
                    ID = 1,
                    EmployeeID = 12,
                    HiredDate = "1",
                    FiredDate = "25",
                    IsActual = true,
                    LevelPositionID = 1,
                    PositionID = 1
                    },
                    new EmployeePositionDTO()
                    {
                    ID = 2,
                    EmployeeID = 2,
                    HiredDate = "2",
                    FiredDate = "2",
                    IsActual = true,
                    LevelPositionID = 1,
                    PositionID = 1
                    }
                },
                new List<Base.Models.Position>()
                {
                    new Base.Models.Position()
                    {
                    ID = 1,
                    EmployeeID = 12,
                    HiredDate = "1",
                    FiredDate = "25",
                    IsActual = true
                    },
                    new Base.Models.Position()
                    {
                    ID = 2,
                    EmployeeID = 2,
                    HiredDate = "2",
                    FiredDate = "2",
                    IsActual = true
                    }
                }
            };
        }
    }
}
