using HR_Application_BLL.Models;
using HR_Application_BLL.Models.Base;
using HR_Application_DB_Logic.Models;
using System.Collections;
using System.Collections.Generic;

namespace HR_Application_BLL.Tests.Souces.Department
{
    public class GetModelsFromDTOSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[]
            {
                new List<DepartmentDTO>()
                {
                    new DepartmentDTO()
                    {
                        ID = 1,
                        Title = "CRM",
                        Description = "CRM doing work"
                    },
                    new DepartmentDTO()
                    {
                        ID = 2,
                        Title = "Mobile",
                        Description = "Mobile doing work"
                    }
                },
                new List<DepartmentModel>()
                {
                    new DepartmentModel()
                    {
                        ID = 1,
                        Title = "CRM",
                        Description = "CRM doing work"
                    },
                    new DepartmentModel()
                    {
                        ID = 2,
                        Title = "Mobile",
                        Description = "Mobile doing work"
                    }
                }
            };
        }
    }
}