using HR_Application_BLL.Models.Base;
using HR_Application_DB_Logic.Models.Base;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace HR_Application_BLL.Tests.Souces.DepartmentProjectsSources
{
    public class GetModelFromDTOSources : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[]
            {
                new DepartmentProjectsDTO()
                {
                    ID = 1,
                    ProjectsID = new List<int>()
                    {
                        1,2,3,4,5
                    },
                    DepartmentID = 1,
                    IsActual = true
                },
                new DepartmentProjectsModel()
                {
                    ID = 1,
                    ProjectsID = new List<int>()
                    {
                        1,2,3,4,5
                    },
                    DepartmentID = 1,
                    IsActual = true
                }
            };
        }
    }
}
