using HR_Application_BLL.Models.Base;
using HR_Application_DB_Logic.Models;
using System.Collections;

namespace HR_Application_BLL.Tests.Souces.Comment
{
    public class GetDTOFromModelSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[]
            {
                new CommentModel()
                {
                    ID = 1,
                    EmployeeID = 1,
                    Information = "CRM doing work",
                    Date = "16th november"
                },
                new CommentDTO()
                {
                    ID = 1,
                    EmployeeID = 1,
                    Information = "CRM doing work",
                    Date = "16th november"
                }
            };
            yield return new object[]
            {
                new CommentModel()
                {
                    ID = 2,
                    EmployeeID = 2,
                    Information = "Mobile doing work",
                    Date = "4th july"
                },
                new CommentDTO()
                {
                    ID = 2,
                    EmployeeID = 2,
                    Information = "Mobile doing work",
                    Date = "4th july"
                }
            };
        }
    }
}
