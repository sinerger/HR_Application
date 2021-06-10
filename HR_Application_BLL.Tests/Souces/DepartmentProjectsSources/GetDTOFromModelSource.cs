using HR_Application_BLL.Models.Base;
using HR_Application_DB_Logic.Models;
using HR_Application_DB_Logic.Models.Base;
using System.Collections;
using System.Collections.Generic;

namespace HR_Application_BLL.Tests.Souces.DepartmentProjectsSources
{
    public class GetDTOFromModelSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[]
            {
                new DepartmentProjectsModel()
                {
                    ID = 1,
                    DepartmentID=1,
                    ProjectsID = new List<int>(){ 1, 2, 3 },
                    IsActual = true
                },
                new DepartmentProjectsDTO()
                {
                    ID = 1,
                    DepartmentID=1,
                    ProjectsID = new List<int>(){ 1, 2, 3 },
                    IsActual = true
                }
            };
            yield return new object[]
            {
                new DepartmentProjectsModel()
                {
                    ID = 2,
                    DepartmentID=2,
                    ProjectsID = new List<int>(){ 4, 5, 6 },
                    IsActual = true
                },
                new DepartmentProjectsDTO()
                {
                    ID = 2,
                    DepartmentID=2,
                    ProjectsID = new List<int>(){ 4, 5, 6 },
                    IsActual = true
                }
            };
        }
    }
}