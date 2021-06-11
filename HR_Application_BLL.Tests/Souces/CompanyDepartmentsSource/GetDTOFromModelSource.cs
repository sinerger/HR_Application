using HR_Application_BLL.Models.Base;
using HR_Application_DB_Logic.Models.Base;
using System.Collections;
using System.Collections.Generic;

namespace HR_Application_BLL.Tests.Souces.CompanyDepartmentsSource
{
    public class GetDTOFromModelSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[]
            {
                new CompanyDepartmentsModel()
                {
                    ID = 1,
                    CompanyID=1,
                    DepartmentsID = new List<int>(){ 1, 2, 3 },
                    IsActual = true
                },
                new CompanyDepartmentsDTO()
                {
                    ID = 1,
                    CompanyID=1,
                    DepartmentsID = new List<int>(){ 1, 2, 3 },
                    IsActual = true
                }
            };
            yield return new object[]
            {
                new CompanyDepartmentsModel()
                {
                    ID = 2,
                    CompanyID=2,
                    DepartmentsID = new List<int>(){ 4, 5, 6 },
                    IsActual = true
                },
                new CompanyDepartmentsDTO()
                {
                    ID = 2,
                    CompanyID=2,
                    DepartmentsID = new List<int>(){ 4, 5, 6 },
                    IsActual = true
                }
            };
        }
    }
}