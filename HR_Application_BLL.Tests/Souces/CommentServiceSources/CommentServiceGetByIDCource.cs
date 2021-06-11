using HR_Application_BLL.Models.Base;
using HR_Application_DB_Logic.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace HR_Application_BLL.Tests.Souces.CommentServiceSources
{
    public class CommentServiceGetByIDCource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[]
            {
                1,
                new CommentDTO()
                {
                    ID = 1,
                    EmployeeID=1,
                    Information = "good employee",
                    Date = "16th november",
                },

                new CommentModel()
                {
                    ID = 1,
                    EmployeeID=1,
                    Information = "good employee",
                    Date = "16th november",
                }
            };
            yield return new object[]
            {
                2,
                new CommentDTO()
                {
                    ID = 2,
                    EmployeeID=2,
                    Information = "bad employee",
                    Date = "17th november",
                },
                new CommentModel()
                {
                    ID = 2,
                    EmployeeID=2,
                    Information = "bad employee",
                    Date = "17th november",
                }
            };
        }
    }
}
