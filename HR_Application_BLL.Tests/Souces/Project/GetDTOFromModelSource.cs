using HR_Application_BLL.Models.Base;
using HR_Application_DB_Logic.Models;
using System.Collections;

namespace HR_Application_BLL.Tests.Souces.Project
{
    public class GetDTOFromModelSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[]
            {
                new ProjectModel()
                {
                    ID = 1,
                    Title="HRApp",
                    Description = "Project for HR",
                    DirectionID = 1
                },
                new ProjectDTO()
                {
                    ID = 1,
                    Title="HRApp",
                    Description = "Project for HR",
                    DirectionID = 1
                }
            };
            yield return new object[]
            {
                new ProjectModel()
                {
                    ID = 2,
                    Title="FlowersApp",
                    Description = "Project for flowers company",
                    DirectionID = 1
                },
                new ProjectDTO()
                {
                    ID = 2,
                    Title="FlowersApp",
                    Description = "Project for flowers company",
                    DirectionID = 1
                }
            };
        }
    }
}