using HR_Application_BLL.Models.Base;
using HR_Application_DB_Logic.Models;
using System.Collections;

namespace HR_Application_BLL.Tests.Souces.DepartmentModelSource
{
    public class GetDTOFromModelSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[]
            {
                new DepartmentModel()
                {
                    ID = 1,
                    Title = "CRM",
                    Description = "CRM doing work"
                },
                new DepartmentDTO()
                {
                    ID = 1,
                    Title = "CRM",
                    Description = "CRM doing work"
                }
            };
            yield return new object[]
            {
                new DepartmentModel()
                {
                    ID = 2,
                    Title = "Mobile",
                    Description = "Mobile doing work"
                },
                new DepartmentDTO()
                {
                    ID = 2,
                    Title = "Mobile",
                    Description = "Mobile doing work"
                }
            };
        }
    }
}