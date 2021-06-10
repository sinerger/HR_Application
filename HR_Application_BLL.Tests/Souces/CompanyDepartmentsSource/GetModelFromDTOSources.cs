using HR_Application_BLL.Models.Base;
using HR_Application_DB_Logic.Models.Base;
using System.Collections;
using System.Collections.Generic;

namespace HR_Application_BLL.Tests.Souces.CompanyDepartmentsSource
{
    public class GetModelFromDTOSources : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[]
            {
                new CompanyDepartmentsDTO()
                {
                    ID = 1,
                    CompanyID = 1,
                    DepartmentsID = new List<int>(),
                    IsActual = true
                },
                new CompanyDepartmentsModel()
                {
                    ID = 1,
                    CompanyID = 1,
                    DepartmentsID = new List<int>(),
                    IsActual = true
                }
            };
        }
    }
}